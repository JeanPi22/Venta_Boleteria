
namespace Venta_Boleteria
{
    partial class Boleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNoBol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbselect = new System.Windows.Forms.ComboBox();
            this.labDocBol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(121, 296);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 15;
            this.lbPrecio.Text = "Precio";
            this.lbPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(110, 344);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 14;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Location = new System.Drawing.Point(339, 38);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(78, 17);
            this.lbBienvenido.TabIndex = 13;
            this.lbBienvenido.Text = "Bienvenido";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(103, 186);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 12;
            // 
            // lblNoBol
            // 
            this.lblNoBol.AutoSize = true;
            this.lblNoBol.Location = new System.Drawing.Point(121, 154);
            this.lblNoBol.Name = "lblNoBol";
            this.lblNoBol.Size = new System.Drawing.Size(64, 17);
            this.lblNoBol.TabIndex = 11;
            this.lblNoBol.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tribuna";
            // 
            // cbselect
            // 
            this.cbselect.FormattingEnabled = true;
            this.cbselect.Location = new System.Drawing.Point(88, 246);
            this.cbselect.Name = "cbselect";
            this.cbselect.Size = new System.Drawing.Size(121, 24);
            this.cbselect.TabIndex = 9;
            // 
            // labDocBol
            // 
            this.labDocBol.AutoSize = true;
            this.labDocBol.Location = new System.Drawing.Point(119, 115);
            this.labDocBol.Name = "labDocBol";
            this.labDocBol.Size = new System.Drawing.Size(80, 17);
            this.labDocBol.TabIndex = 8;
            this.labDocBol.Text = "Documento";
            this.labDocBol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lbBienvenido);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblNoBol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbselect);
            this.Controls.Add(this.labDocBol);
            this.Name = "Boleta";
            this.Text = "Boleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblNoBol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbselect;
        private System.Windows.Forms.Label labDocBol;
    }
}