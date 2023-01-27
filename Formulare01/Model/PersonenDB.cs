using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Formulare01.Model
{
    public class PersonenDB : IDisposable
    {

        private string strCon;
        private SqlConnection connection;

        public PersonenDB()
        {
            strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PersonenDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(strCon);
            connection.Open();
        }

        public void Dispose()
        {
            connection?.Close();
        }
        public List<Person> GetPersonen()
        {
            List<Person> list = new List<Person>();
            string sql = "select id, vorname,nachname,geburt,geschlecht from tblpersonen";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader  reader = command.ExecuteReader();
            while(reader.Read())
            {
                Person person = new Person();
                person.Id = (int)reader["id"];
                person.Nachname = (string)reader["nachname"];
                person.Vorname = (string)reader["vorname"];
                person.Geburt = (DateTime)reader["geburt"];
                person.Geschlecht = (Geschlecht)(int)reader["geschlecht"];
                list.Add(person);
            }
            return list;
        }
        public void InsertPerson(Person p)
        {
            string sql = "insert into tblpersonen(vorname,nachname,geburt,geschlecht)" +
                " values(@vorname,@nachname,@geburt,@geschlecht)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@vorname", p.Vorname);
            command.Parameters.AddWithValue("@nachname", p.Nachname);
            command.Parameters.AddWithValue("@geburt", p.Geburt);
            command.Parameters.AddWithValue("@geschlecht", p.Geschlecht);
            command.ExecuteNonQuery();
        }


    }
}