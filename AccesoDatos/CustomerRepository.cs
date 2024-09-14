using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public DataTable Obtenertodos()
        {
            DataTable dataTable = new DataTable();
            String select = "";
            select = select + "SELECT [CustomerID] " + "\n";
            select = select + "      ,[CompanyName] " + "\n";
            select = select + "      ,[ContactName] " + "\n";
            select = select + "      ,[ContactTitle] " + "\n";
            select = select + "      ,[Address] " + "\n";
            select = select + "      ,[City] " + "\n";
            select = select + "      ,[Region] " + "\n";
            select = select + "      ,[PostalCode] " + "\n";
            select = select + "      ,[Country] " + "\n";
            select = select + "      ,[Phone] " + "\n";
            select = select + "      ,[Fax] " + "\n";
            select = select + "  FROM [dbo].[Customers]";

            var conexion = @"Data Source=DESKTOP-5R5EQO8\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;";
            SqlDataAdapter adapter = new SqlDataAdapter(select, conexion);
            adapter.Fill(dataTable);

            return dataTable;
        }

        public Customer ObetenerPorId(string id)
        {
            
            using (var conexion = DataBase.SqlConnection())
            {
                var dataTable = new DataTable();

                String selectForId = "";
                selectForId = selectForId + "SELECT [CustomerID] " + "\n";
                selectForId = selectForId + "      ,[CompanyName] " + "\n";
                selectForId = selectForId + "      ,[ContactName] " + "\n";
                selectForId = selectForId + "      ,[ContactTitle] " + "\n";
                selectForId = selectForId + "      ,[Address] " + "\n";
                selectForId = selectForId + "      ,[City] " + "\n";
                selectForId = selectForId + "      ,[Region] " + "\n";
                selectForId = selectForId + "      ,[PostalCode] " + "\n";
                selectForId = selectForId + "      ,[Country] " + "\n";
                selectForId = selectForId + "      ,[Phone] " + "\n";
                selectForId = selectForId + "      ,[Fax] " + "\n";
                selectForId = selectForId + "  FROM [dbo].[Customers] " + "\n";
                selectForId = selectForId + "  Where CustomerID = @CustomerID";
                using (var comando = new SqlCommand(selectForId, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", id);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dataTable);
                    Customer cliente = ExtraerInfoCliente(dataTable);
                    return cliente;
                }
            }
        }

        public Customer ExtraerInfoCliente(DataTable dataTeble)
        {
            Customer customer = new Customer();
            foreach (DataRow fila in dataTeble.Rows)
            {
                customer.CustomerID = fila.Field<string>("CustomerID");
                customer.CompanyName = fila.Field<string>("CompanyName");
                customer.ContactName = fila.Field<string>("ContactName");
                customer.ContactTitle = fila.Field<string>("ContactTitle");
                customer.Address = fila.Field<string>("Address");
                customer.City = fila.Field<string>("City");
                customer.Region = fila.Field<string>("Region");
                customer.PostalCode = fila.Field<string>("PostalCode");
                customer.Country = fila.Field<string>("Country");
                customer.Phone = fila.Field<string>("Phone");
                customer.Fax = fila.Field<string>("Fax");

            }
            return customer;
        }

        public int InsertarCliente(Customer cliente)
        {
            using (var conexion = DataBase.SqlConnection())
            {
                String insertIntoPorId = "";
                insertIntoPorId = insertIntoPorId + "INSERT INTO [dbo].[Customers] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ([CustomerID] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[CompanyName] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[ContactName] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[ContactTitle] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[Address])" + "\n";
                insertIntoPorId = insertIntoPorId + "     VALUES " + "\n";
                insertIntoPorId = insertIntoPorId + "           (@CustomerID " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@CompanyName " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@ContactName " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@ContactTitle " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@Address)";

                using (var comando=new SqlCommand(insertIntoPorId,conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", cliente.CustomerID);
                    comando.Parameters.AddWithValue("@CompanyName", cliente.CompanyName);
                    comando.Parameters.AddWithValue("@ContactName", cliente.ContactName);
                    comando.Parameters.AddWithValue("@ContactTitle", cliente.ContactTitle);
                    comando.Parameters.AddWithValue("@Address", cliente.Address);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.InsertCommand = comando;
                    return adaptador.InsertCommand.ExecuteNonQuery();
                }
            }
        }
    }

}
