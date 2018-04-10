using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestArbolGuaflix.Clases;

namespace Clases
{
    public class Node<T> : IFixedSizeText
    {
        public List<ECatalogo> Valores { get; set; }
        public List<int> Hijos { get; set; }
        public int Padre { get; set; }
        public int Posicion { get; set; }
        public int Orden { get; set; }

        public static int FixedSize { get { return 76; } }

        public int FixedSizeText { get { return FixedSize; } }

        public string HijosFormat()
        {
            string hijos = null;
            for (int i = 0; i < Orden; i++)
            {
                if(Hijos[i] != int.MaxValue)
                {
                    hijos = hijos + $"|{Hijos[i].ToString("00000000000;-00000000000")}";
                }
                else
                {
                    hijos = hijos + $"|{int.MaxValue.ToString("00000000000;-00000000000")}";
                }
            }
            return hijos;
        }
        public string ValoresFormat()
        {
            string val = null;
            for (int i = 0; i < (Orden - 1); i++)
            {
                if (Valores.ElementAt(i) != null)
                {
                    val = val + Valores.ElementAt(i).ToFixedLenghtString();
                }
                else
                {
                    val = val + $"|{int.MaxValue.ToString("00000000000;-00000000000")}";
                }
            }
            return val;
        }

        public string ToFixedLenghtString()
        {
            return $"{Posicion.ToString("00000000000;-0000000000")}|{Padre.ToString("00000000000;-0000000000")}" + HijosFormat() + ValoresFormat() + "\r\n";
        }
    }
    public class BTree
    {

    }

}
