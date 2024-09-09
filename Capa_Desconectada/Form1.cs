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

        #region tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }

        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(txtBuscarT.Text);

            if (customer!=null)
            {
                var objeto = customerRepository.ExtraerInfoCliente(customer);
                //var listaClientes = new List<Customer> { objeto };
                //gridTipado.DataSource = listaClientes;

                var encontrado = objeto.CompanyName;

                txtEncontrado2.Text = encontrado;
            }
        }
        #endregion


        #region no tipado
        private CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click_1(object sender, EventArgs e)
        {
            gridNoTipado.DataSource = customerRepository.Obtenertodos();
        }

        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObetenerPorId(txtBuscarNT.Text);

            if (cliente==null)
            {
                MessageBox.Show("No encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //var listaClientes = new List<Customer> { cliente };
                //gridNoTipado.DataSource = listaClientes;

                var encontrado = cliente.CompanyName;

                txtEncontrado.Text = encontrado;

            }
        }
        #endregion
    }
}