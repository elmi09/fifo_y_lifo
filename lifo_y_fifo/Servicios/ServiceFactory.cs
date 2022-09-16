using lifo_y_fifo.Servicios.Implementaciones;
using lifo_y_fifo.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo_y_fifo.Servicios
{
    internal class ServiceFactory:AbstractServicesFactory
    {
        public override IColleccion CrearService()
        {
            return new PilaService();
        }
    }
}
