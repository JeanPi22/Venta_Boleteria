
namespace Venta_Boleteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.txtLogDoc = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(408, 290);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registro";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(300, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(270, 237);
            this.txtCont.Name = "txtCont";
            this.txtCont.PasswordChar = '*';
            this.txtCont.Size = new System.Drawing.Size(261, 22);
            this.txtCont.TabIndex = 9;
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.Location = new System.Drawing.Point(360, 208);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(81, 17);
            this.lbContrasena.TabIndex = 8;
            this.lbContrasena.Text = "Contraseña";
            // 
            // txtLogDoc
            // 
            this.txtLogDoc.Location = new System.Drawing.Point(269, 170);
            this.txtLogDoc.Name = "txtLogDoc";
            this.txtLogDoc.Size = new System.Drawing.Size(261, 22);
            this.txtLogDoc.TabIndex = 7;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(361, 138);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(80, 17);
            this.lbDocumento.TabIndex = 6;
            this.lbDocumento.Text = "Documento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.txtLogDoc);
            this.Controls.Add(this.lbDocumento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.TextBox txtLogDoc;
        private System.Windows.Forms.Label lbDocumento;
    }
}

