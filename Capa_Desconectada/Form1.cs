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

        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            String selectALl = "";
            selectALl = selectALl + "SELECT [CustomerID] " + "\n";
            selectALl = selectALl + "      ,[CompanyName] " + "\n";
            selectALl = selectALl + "      ,[ContactName] " + "\n";
            selectALl = selectALl + "      ,[ContactTitle] " + "\n";
            selectALl = selectALl + "      ,[Address] " + "\n";
            selectALl = selectALl + "      ,[City] " + "\n";
            selectALl = selectALl + "      ,[Region] " + "\n";
            selectALl = selectALl + "      ,[PostalCode] " + "\n";
            selectALl = selectALl + "      ,[Country] " + "\n";
            selectALl = selectALl + "      ,[Phone] " + "\n";
            selectALl = selectALl + "      ,[Fax] " + "\n";
            selectALl = selectALl + "  FROM [dbo].[Customers]";

            var conexion = @"Data Source=DESKTOP-5R5EQO8\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;";
            SqlDataAdapter adapter = new SqlDataAdapter(selectALl,conexion);

            adapter.Fill(dataTable);
            gridNoTipado.DataSource = dataTable;


        }
    }
}
