using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_Boleteria.CapaDatos;
using Venta_Boleteria.CapaNegocios;

namespace Venta_Boleteria
{
    public partial class Boleta : Form
    {
        private Datos_Compra objCDcompra = new Datos_Compra();
        public Boleta(Form1.Datos doc)
        {
            InitializeComponent();
            labDocBol.Text= "Documento: " + doc.Documento;            
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {
            int total;
            total = int.Parse(txtCantidad.Text) * int.Parse(lbPrecio.Text);
        }

        private void Boleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'venta_BoleteriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.venta_BoleteriaDataSet.Localidad);

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            objCDcompra.CrearCompra
                (int.Parse(labDocBol.Text), int.Parse(txtCantidad.Text), cbselect.Text);
            MessageBox.Show("Compra realizada");
        }

        private void cbselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
