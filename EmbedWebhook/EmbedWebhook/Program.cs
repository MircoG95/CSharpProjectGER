

using Newtonsoft.Json;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start");

        try
        {
            Console.WriteLine("Enter the Webhook URL: ");
            string token = Console.ReadLine();

            WebRequest wr = (HttpWebRequest)WebRequest.Create(token);

            wr.ContentType = "application/json";
            wr.Method = "POST";

            using (StreamWriter sw = new StreamWriter(wr.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    username = "Test Username",
                    embeds = new[]
                    {
                        new
                        {
                            description = "test Desc.",
                            title = "Test Title",
                            color = "8464385"

                        }
                    }
                });
                sw.Write(json);
            }
            HttpWebResponse response = (HttpWebResponse)wr.GetResponse();
            Console.WriteLine("End");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }


    }
}