using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security = SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string sql = "select ProductName from [dbo].[Products]";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexion.Open();
            MessageBox.Show("Se abri� la conexi�n con el servidor SQL Server y se seleccion� la base de datos");
            reader = cmd.ExecuteReader();
            listBox1.Text = reader.ToString();
            conexion.Close();
            MessageBox.Show("Se cerr� la conexi�n.");
        }
    }
}
