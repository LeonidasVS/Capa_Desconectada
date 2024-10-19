using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Desconectada
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwinds.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwinds.Customers);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            customersTableAdapter.Update(northwinds);
            MessageBox.Show("Guardado");
        }
    }
}
