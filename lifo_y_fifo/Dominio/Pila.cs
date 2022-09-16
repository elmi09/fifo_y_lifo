using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo_y_fifo.Dominio
{
    internal class Pila
    {
        public string pila { get; set; }



        public Pila(string pila)
        {
            this.pila = pila;
        }

        public override string ToString()
        {
            return pila;
        }
    }
}
