using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestArbolGuaflix.Class;

namespace TestArbolGuaflix.Models
{
    public class Pelicula: IComparable, IFixedSizeText
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int year { get; set; }
        public string genero { get; set; }

        public static int FixedSize { get { return 76; } }

        public int FixedSizeText { get { return FixedSize; } }

        public string ToFixedLenghtString()
        {
            return $"{id.ToString("00000000000;-0000000000")}|{string.Format("{0,-20}", nombre)}|" +
                   $"{string.Format("{0,-20}", year)}|{string.Format("{0,-20}", genero)}\r\n";
        }

        public int CompareTo(object obj)
        {
            var s2 = (Pelicula)obj;
            return id.CompareTo(s2.id);
        }
    }
}