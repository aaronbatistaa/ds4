using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                StringBuilder tabla = new StringBuilder();
                for (int i = 1; i <= 25; i++)   //genera la tabla
                {
                    tabla.AppendLine($"<p>{numero} x {i} = {numero * i}</p>");
                }

                // muestra la tabla
                litTabla.Text = tabla.ToString();
                pnlResultado.Visible = true;
                lblResultado.Text = "";
            }
            else
            {
                // manejo de error
                lblResultado.Text = "Por favor, ingrese un número válido.";
                pnlResultado.Visible = false;
            }
        }
    }
}