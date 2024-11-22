using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio203
{
    public partial class Default : System.Web.UI.Page
    {
        string connectionString = @"Server=.\sqlexpress;Database=Productos;Trusted_Connection=True;";
        bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializarControles();
            }
        }

        private void InicializarControles()
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        protected void tsbNuevo_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            nuevo = true;
        }

        protected void tsbGuardar_Click(object sender, EventArgs e)
        {
            string sql;

            if (nuevo)
            {
                sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@Nombre, @Precio, @Stock)";
            }
            else
            {
                sql = "UPDATE LAPTOPS SET NOMBRE = @Nombre, PRECIO = @Precio, STOCK = @Stock WHERE ID = @Id";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (!nuevo)
                {
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                }
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@Stock", txtStock.Text);

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Response.Write("<script>alert('Operación realizada con éxito');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }

            InicializarControles();
        }

        protected void tsbCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        protected void tsbEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE ID = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Response.Write("<script>alert('Registro eliminado con éxito');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }

            InicializarControles();
        }

        protected void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", tstId.Text);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtId.Text = reader["ID"].ToString();
                        txtNombre.Text = reader["NOMBRE"].ToString();
                        txtPrecio.Text = reader["PRECIO"].ToString();
                        txtStock.Text = reader["STOCK"].ToString();

                        tsbNuevo.Enabled = false;
                        tsbGuardar.Enabled = true;
                        tsbCancelar.Enabled = true;
                        tsbEliminar.Enabled = true;
                        txtNombre.Enabled = true;
                        txtPrecio.Enabled = true;
                        txtStock.Enabled = true;
                        nuevo = false;
                    }
                    else
                    {
                        Response.Write("<script>alert('No se encontró el registro');</script>");
                    }
                }
            }
        }
    }
}