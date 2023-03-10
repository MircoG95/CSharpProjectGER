using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjekte
{
    public class Punkt
    {
        public static int anzahl = 0;
        private string name;
        public double x;
        public double y;
        public Color farbe;

        public Punkt()
        {
            anzahl++;
            name = "Punkt " + anzahl.ToString();
        }

        public string GetInfo()
        {
            string info = "";

            info += name + "\r\n";
            info += $"P: ({x}|{y})\r\n";
            info += "Farbe: " + farbe.Name + Environment.NewLine;

            return info;
        }


        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return getName();
        }
    }
}
