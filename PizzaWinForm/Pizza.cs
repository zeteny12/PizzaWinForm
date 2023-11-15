using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWinForm
{
    internal class Pizza
    {
        int pizzaid;
        string pizzanev;
        int pizzaar;

        public Pizza(string Beovlas)
        {
            string[] darabok = Beovlas.Split(';');
            pizzaid = int.Parse(darabok[0]);
            pizzanev = darabok[1];
            pizzaar = int.Parse(darabok[2]);
        }

        public int Pizzaid { get => pizzaid; set => pizzaid = value; }
        public string Pizzanev { get => pizzanev; set => pizzanev = value; }
        public int Pizzaar { get => pizzaar; set => pizzaar = value; }

        public override string ToString()
        {
            return $"{pizzanev}, melynek ára: {pizzaar}Ft";
        }
    }
}
