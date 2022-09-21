using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_Boleteria.CapaNegocios;

namespace Venta_Boleteria
{
    public partial class Form1 : Form
    {
        private Neg_Usuario objCNusu = new Neg_Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogDoc.Text != "") //Valida que el campo del documento no quede vacio
            {
                if (txtCont.Text != "") //Valida que el campo de la contraseña no quede vacio
                {
                    //Variable implicita "LoginValidacion" al que se le aasignara el valor
                    //de leer usuario de la Capa de Negocio
                    var LoginValidacion = objCNusu.LeerUsuarioLogin(int.Parse(txtLogDoc.Text), txtCont.Text);
                    if (LoginValidacion == true)
                    {
                        Datos doc;
                        doc.Documento = int.Parse(txtLogDoc.Text);

                        Boleta boleta = new Boleta(doc);
                        boleta.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Documento o contraseña incorrectos \n Por favor intentalo nuevamente");
                        txtLogDoc.Clear();
                        txtCont.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese su contraseña");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese su documento");
            }
        }

        //Estructura para pasar dato del documento al formulario de compra
        public struct Datos
        {
            public int Documento;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
