namespace Capa_Desconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarNT = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Label();
            this.txtBuscarNT = new System.Windows.Forms.TextBox();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.btnBuscarT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.txtEncontrado = new System.Windows.Forms.TextBox();
            this.txtEncontrado2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEncontrado2);
            this.groupBox1.Controls.Add(this.btnBuscarT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerTipado);
            this.groupBox1.Controls.Add(this.txtBuscarT);
            this.groupBox1.Controls.Add(this.gridTipado);
            this.groupBox1.Location = new System.Drawing.Point(406, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet Tipado";
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(116, 241);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(119, 23);
            this.btnObtenerTipado.TabIndex = 2;
            this.btnObtenerTipado.Text = "Obtener datos Tipado";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(21, 64);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(305, 158);
            this.gridTipado.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEncontrado);
            this.groupBox2.Controls.Add(this.btnBuscarNT);
            this.groupBox2.Controls.Add(this.Buscar);
            this.groupBox2.Controls.Add(this.txtBuscarNT);
            this.groupBox2.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox2.Controls.Add(this.gridNoTipado);
            this.groupBox2.Location = new System.Drawing.Point(32, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet no Tipado";
            // 
            // btnBuscarNT
            // 
            this.btnBuscarNT.Location = new System.Drawing.Point(117, 351);
            this.btnBuscarNT.Name = "btnBuscarNT";
            this.btnBuscarNT.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNT.TabIndex = 4;
            this.btnBuscarNT.Text = "Buscar";
            this.btnBuscarNT.UseVisualStyleBackColor = true;
            this.btnBuscarNT.Click += new System.EventHandler(this.btnBuscarNT_Click);
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(57, 278);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(40, 13);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            // 
            // txtBuscarNT
            // 
            this.txtBuscarNT.Location = new System.Drawing.Point(103, 275);
            this.txtBuscarNT.Name = "txtBuscarNT";
            this.txtBuscarNT.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarNT.TabIndex = 2;
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(86, 227);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(169, 23);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Obtener Datos NO Tipado";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click_1);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(21, 49);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(305, 158);
            this.gridNoTipado.TabIndex = 0;
            // 
            // btnBuscarT
            // 
            this.btnBuscarT.Location = new System.Drawing.Point(134, 351);
            this.btnBuscarT.Name = "btnBuscarT";
            this.btnBuscarT.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarT.TabIndex = 7;
            this.btnBuscarT.Text = "Buscar";
            this.btnBuscarT.UseVisualStyleBackColor = true;
            this.btnBuscarT.Click += new System.EventHandler(this.btnBuscarT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Location = new System.Drawing.Point(109, 287);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarT.TabIndex = 5;
            // 
            // txtEncontrado
            // 
            this.txtEncontrado.Location = new System.Drawing.Point(117, 313);
            this.txtEncontrado.Name = "txtEncontrado";
            this.txtEncontrado.Size = new System.Drawing.Size(100, 20);
            this.txtEncontrado.TabIndex = 5;
            // 
            // txtEncontrado2
            // 
            this.txtEncontrado2.Location = new System.Drawing.Point(124, 317);
            this.txtEncontrado2.Name = "txtEncontrado2";
            this.txtEncontrado2.Size = new System.Drawing.Size(100, 20);
            this.txtEncontrado2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.Button btnBuscarNT;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox txtBuscarNT;
        private System.Windows.Forms.Button btnBuscarT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarT;
        private System.Windows.Forms.TextBox txtEncontrado2;
        private System.Windows.Forms.TextBox txtEncontrado;
    }
}

