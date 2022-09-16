using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo_y_fifo.Dominio
{
    internal class Cola
    {
        public string cola { get; set; }



        public Cola(string pila)
        {
            this.cola = pila;
        }

        public override string ToString()
        {
            return cola;
        }
    }
}
