using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio202
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n) && n > 0)
            {
                StringBuilder matrizHTML = new StringBuilder();
                matrizHTML.Append("<table>");

                // genera la matriz
                for (int i = 0; i < n; i++)
                {
                    matrizHTML.Append("<tr>");
                    for (int j = 0; j < n; j++)
                    {
                        // condiciona para verificar si es parte de la diagonal inversa
                        if (i + j == n - 1)
                        {
                            matrizHTML.Append("<td>1</td>");
                        }
                        else
                        {
                            matrizHTML.Append("<td>0</td>");
                        }
                    }
                    matrizHTML.Append("</tr>");
                }

                matrizHTML.Append("</table>");

                // muestra matriz generada
                litMatriz.Text = matrizHTML.ToString();
                pnlMatriz.Visible = true;
            }
            else
            {
                // manejo para error
                litMatriz.Text = "<p style='color:red;'>Por favor, ingrese un número entero positivo.</p>";
                pnlMatriz.Visible = true;
            }
        }
    }
}