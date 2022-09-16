using lifo_y_fifo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo_y_fifo.Servicios.Interfaces
{
    internal interface IColleccion
    {
        bool estaVacia(int cont);

        string extraer(List<Pila> array);

        string primero(List<Pila> array);

        bool añadir(int cont, List<Pila> arrayy, Pila pila);

        bool estaVaciaCola(int cont);

        string extraerCola(List<Cola> array);

        string primeroCola(List<Cola> array);

        bool añadirCola(int cont, List<Cola> arrayy, Cola cola);
    }
}
