using System;

namespace Formulare01.Model
{
    public enum Geschlecht { Weiblich = 1, Maennlich = 2, Divers = 3 }
    public class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburt { get; set; }
        public Geschlecht Geschlecht { get; set; }
        
    }
}