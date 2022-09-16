using lifo_y_fifo.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo_y_fifo.Servicios
{
    abstract class AbstractServicesFactory
    {
        public abstract IColleccion CrearService();
    }
}
