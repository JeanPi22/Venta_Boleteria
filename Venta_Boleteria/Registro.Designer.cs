
namespace Venta_Boleteria
{
    partial class Registro
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.labClave = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.labCorreo = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labNom = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(354, 334);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(210, 285);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(380, 22);
            this.txtCont.TabIndex = 16;
            // 
            // labClave
            // 
            this.labClave.AutoSize = true;
            this.labClave.Location = new System.Drawing.Point(368, 265);
            this.labClave.Name = "labClave";
            this.labClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labClave.Size = new System.Drawing.Size(81, 17);
            this.labClave.TabIndex = 15;
            this.labClave.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(210, 228);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(380, 22);
            this.txtCorreo.TabIndex = 14;
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Location = new System.Drawing.Point(368, 208);
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labCorreo.Size = new System.Drawing.Size(51, 17);
            this.labCorreo.TabIndex = 13;
            this.labCorreo.Text = "Correo";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(210, 171);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(380, 22);
            this.txtNom.TabIndex = 12;
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(320, 151);
            this.labNom.Name = "labNom";
            this.labNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labNom.Size = new System.Drawing.Size(137, 17);
            this.labNom.TabIndex = 11;
            this.labNom.Text = "Nombres y Apellidos";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(210, 114);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(380, 22);
            this.txtDocumento.TabIndex = 10;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(351, 94);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDocumento.Size = new System.Drawing.Size(80, 17);
            this.lbDocumento.TabIndex = 9;
            this.lbDocumento.Text = "Documento";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.labClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.labCorreo);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lbDocumento);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label labClave;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label labCorreo;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lbDocumento;
    }
}