using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox teste = (TextBox)PreviousPage.FindControl("txtUsuario");
            lblTeste.Text = Request.QueryString["txtUsuario"];
           // lblTeste.Text = teste.Text.ToString();
        }
    }
}