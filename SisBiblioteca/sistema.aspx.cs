using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string usuario = Request.QueryString["txtUsuario"];
            string senha = Request.QueryString["txtSenha"];
            Usuario user = new Usuario();
            user.User = usuario;
            user.Senha = senha;
            */
            //if (user.Login(user))
            /* testa se a sessão para usuário e senha existem */
            if(Session["user"]  == null && Session["pass"] == null)
            {
                /* caso não exista retorna para "index.aspx" */
                Response.Write(
                "<script> alert('Favor fazer login!');" +
                "window.location.href = 'index.aspx';</script>");
                /*
                string resp = "Usuário não encontrado";
                Response.Redirect("index.aspx?resp=" + resp);
                */
            }
            else
            {
                /* se existir sessão usa os valores para preencher "label" */
                lblLogin.Text = Session["nome"].ToString();
                /*exibir nome completo do usuário que esta na lista*/
                //lblLogin.Text += "<br/>" + user.NomeUsuario(user);
            }

            
        }

        protected void btnCadUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadUsuario.aspx");
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("index.aspx");
        }
    }
}