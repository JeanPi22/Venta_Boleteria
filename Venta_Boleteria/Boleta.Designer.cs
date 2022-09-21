
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
            this.components = new System.ComponentModel.Container();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNoBol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbselect = new System.Windows.Forms.ComboBox();
            this.labDocBol = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.venta_BoleteriaDataSet = new Venta_Boleteria.Venta_BoleteriaDataSet();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new Venta_Boleteria.Venta_BoleteriaDataSetTableAdapters.LocalidadTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.venta_BoleteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(121, 285);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 15;
            this.lbPrecio.Text = "Precio";
            this.lbPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(110, 354);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 14;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
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
            this.cbselect.Items.AddRange(new object[] {
            "Sur",
            "Norte",
            "Oriental",
            "Occidental"});
            this.cbselect.Location = new System.Drawing.Point(93, 246);
            this.cbselect.Name = "cbselect";
            this.cbselect.Size = new System.Drawing.Size(121, 24);
            this.cbselect.TabIndex = 9;
            this.cbselect.SelectedIndexChanged += new System.EventHandler(this.cbselect_SelectedIndexChanged);
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
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(121, 320);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 17);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "Total";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // venta_BoleteriaDataSet
            // 
            this.venta_BoleteriaDataSet.DataSetName = "Venta_BoleteriaDataSet";
            this.venta_BoleteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "Localidad";
            this.localidadBindingSource.DataSource = this.venta_BoleteriaDataSet;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 292);
            this.dataGridView1.TabIndex = 17;
            // 
            // Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTotal);
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
            this.Load += new System.EventHandler(this.Boleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venta_BoleteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lbTotal;
        private Venta_BoleteriaDataSet venta_BoleteriaDataSet;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private Venta_BoleteriaDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}