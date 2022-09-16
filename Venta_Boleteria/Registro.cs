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
    public partial class Registro : Form
    {
        private Datos_Usuario objCDusu = new Datos_Usuario();
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objCDusu.CrearUsuario(int.Parse(txtDocumento.Text), txtNom.Text, txtCorreo.Text, txtCont.Text);
            MessageBox.Show("Usuario Registrado");

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
