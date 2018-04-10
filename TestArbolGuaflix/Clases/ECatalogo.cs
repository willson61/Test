using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestArbolGuaflix.Clases;

namespace Clases
{
    public class ECatalogo : IComparable, IFixedSizeText
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Year { get; set; }
        public string Genero { get; set; }
        public string Tipo { get; set; }

        public int CompareTo(object obj)
        {
            var s2 = (ECatalogo)obj;
            return Id.CompareTo(s2.Id);
        }

        public static int FixedSize { get { return 127; } }

        public string ToFixedLenghtString()
        {
            //{0}|{1}|{2}|{3}|{4} para poner las propiedades
            //00000000000;-0000000000 nos devuelve un entero de longitud fija
            //"{0,-20}", Name  -- Nombre de 20 caracteres sin importar la longitud
            return $"|{Id.ToString("00000000000;-0000000000")}|{string.Format("{0,-20}", Nombre)}|" +
                   $"{string.Format("{0,-20}", Year)}|{string.Format("{0,-20}", Genero)}|" +
                   $"{string.Format("{0,-50}", Tipo)}";
        }

        public int FixedSizeText
        {
            //return suma de todos los caracteres en ToFixedSizeString
            get { return FixedSize; }
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\r\nNombre: {1}\r\nAño: {2}\r\nGénero: {3}\r\nTipo: {4}\r\n"
                , Id.ToString("00000000000;-0000000000"), string.Format("{0,-20}", Nombre)
                , string.Format("{0,-20}", Year), string.Format("{0,-20}", Genero), string.Format("{0,-50}", Tipo));
        }
    }
}
