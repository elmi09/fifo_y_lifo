using lifo_y_fifo.Dominio;
using lifo_y_fifo.Servicios;
using lifo_y_fifo.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lifo_y_fifo
{
    public partial class Form1 : Form
    {
        string elemento;
        int contador = 0;
        int contadorcola = 0;
        IColleccion oColleccion = new ServiceFactory().CrearService();

        private List<Pila> collecionpila = new List<Pila>();
        private List<Cola> collecioncola = new List<Cola>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            elemento = Convert.ToString(txtAgregarPila.Text);
            Pila oPila = new Pila(elemento);
            oColleccion.añadir(contador, collecionpila, oPila);
            actualizarPila();
            txtAgregarPila.Text = "";
            txtAgregarPila.Focus();
        }
        private void actualizarPila()
        {
            lstPila.DataSource = null;
            lstPila.DataSource = collecionpila;


        }

        private void btnQuitarPila_Click(object sender, EventArgs e)
        {
            txtAgregarPila.Text = oColleccion.extraer(collecionpila);
            actualizarPila();
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            elemento = Convert.ToString(txtgAgregarCola.Text);
            Cola oCola = new Cola(elemento);
            oColleccion.añadirCola(contadorcola, collecioncola, oCola);
            actualizarCola();
            txtgAgregarCola.Text = "";
            txtgAgregarCola.Focus();
        }

        private void actualizarCola()
        {
            lstCola.DataSource = null;
            lstCola.DataSource = collecioncola;
        }

        private void btnQuitaCola_Click(object sender, EventArgs e)
        {
            txtgAgregarCola.Text = oColleccion.extraerCola(collecioncola);
            actualizarCola();
        }

        private void btnPrimerElementoPila_Click(object sender, EventArgs e)
        {
            txtAgregarPila.Text = oColleccion.primero(collecionpila);
        }

        private void btnPrimerElementoCola_Click(object sender, EventArgs e)
        {
            txtgAgregarCola.Text = oColleccion.primeroCola(collecioncola);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }
    }
}
