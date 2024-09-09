using AccesoDatos;
using Capa_Desconectada.NorthwindsTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Desconectada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region No tipado
        private CustomerRepository customer = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {

            gridNoTipado.DataSource = customer.ObtenerTodos();

        }
        #endregion

        #region tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetData();
            gridTipado.DataSource = customer;
        }
        #endregion
    }
}
