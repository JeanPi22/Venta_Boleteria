﻿using System;
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
            in
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
