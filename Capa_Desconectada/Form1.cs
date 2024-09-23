using AccesoDatos;
using Capa_Desconectada.NorthwindsTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Serialization;
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

        private void RellenarCampos(Customer cliente)
        {
            if (cliente != null)
            {
                txtCustomerID.Text = cliente.CustomerID;
                txtCompanyName.Text = cliente.CompanyName;
                txtContactName.Text = cliente.ContactName;
                txtAddres.Text = cliente.Address;
                txtContactTitle.Text = cliente.ContactTitle;

            }
            else if (cliente == null)
            {
                MessageBox.Show("Objeto no encontrado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCustomerID.Enabled = true;
        }

        private void Limpiar()
        {
            txtCustomerID.Text = "";
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddres.Text = "";
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
                RellenarCampos(objeto);
                txtCustomerID.Enabled=false;
            }
        }
        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int resutado=adaptador.Insert(cliente.CustomerID, cliente.CompanyName, cliente.ContactName, cliente.ContactTitle, cliente.Address,
                cliente.City, cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone, cliente.Fax);

            if (resutado>0)
            {
                MessageBox.Show("Se ingreso");
                Limpiar();
            }
        }

        private void btnActualizarTipado_Click(object sender, EventArgs e)
        {
            var fila = adaptador.GetDataByCustomerID(txtCustomerID.Text);

            if (fila!=null)
            {
                var datoOriginal = customerRepository.ExtraerInfoCliente(fila);
                var datosModificados = CrearCliente();

                adaptador.Update(
                    datosModificados.CustomerID,
             datosModificados.CompanyName,
             datosModificados.ContactName,
             datosModificados.ContactTitle,
             datosModificados.Address,
             datosModificados.City,
             datosModificados.Region,
             datosModificados.PostalCode,
             datosModificados.Country,
             datosModificados.Phone,
             datosModificados.Fax,
             datoOriginal.CustomerID,
             datoOriginal.CompanyName,
             datoOriginal.ContactName,
             datoOriginal.ContactTitle,
             datoOriginal.Address,
             datoOriginal.City,
             datoOriginal.Region,
             datoOriginal.PostalCode,
             datoOriginal.Country,
             datoOriginal.Phone,
             datoOriginal.Fax);

                MessageBox.Show("Usuario actualizado");
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
                RellenarCampos(cliente);
                txtCustomerID.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int resultado = customerRepository.InsertarCliente(cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente insertado con EXITO", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Cliente insertado NO INSERTADO", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddres.Text
            };
            return cliente;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actulaizadas = customerRepository.ActualizarCliente(cliente);
            MessageBox.Show($"{actulaizadas} filas actulizadas");
            Limpiar();
        }
        #endregion

    }
}