using lifo_y_fifo.Dominio;
using lifo_y_fifo.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo_y_fifo.Servicios.Implementaciones
{
    internal class PilaService:IColleccion
    {
        public bool añadir(int cont, List<Pila> arrayy, Pila pila)
        {
            arrayy.Add(pila);
            cont++;
            return true;
        }



        public bool estaVacia(int cont)
        {
            return cont == 0;
        }

        public string extraer(List<Pila> array)
        {
            string nombre = array[array.Count - 1].pila;
            array.RemoveAt(array.Count - 1);
            return nombre;
        }

        public string primero(List<Pila> array)
        {
            return array[0].pila;
        }


        public bool añadirCola(int cont, List<Cola> arrayy, Cola cola)
        {
            arrayy.Add(cola);
            cont++;
            return true;
        }



        public bool estaVaciaCola(int cont)
        {
            return cont == 0;
        }

        public string extraerCola(List<Cola> array)
        {
            string nombre = array[0].cola;
            array.RemoveAt(0);
            return nombre;
        }

        public string primeroCola(List<Cola> array)
        {
            return array[0].cola;
        }
    }
}
