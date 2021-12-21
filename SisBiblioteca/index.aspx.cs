using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   /*
            string r = Request.QueryString["resp"];
            if (r != null)
            {
                 Response.Write("<script> alert('" + r + "');</script>");
            }*/
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            /* Cria caminho web para a página */
            string url = "sistema.aspx";
            /* Instância de classe "Usuario" para poder
             * acessar funções e campos */
            Usuario objUsuario = new Usuario();
            /* atribuir valor de usuario e senha na classe */
            objUsuario.User  = txtUsuario.Text;
            objUsuario.Senha = txtSenha.Text;
            /* verifica se o método login retorna "true" */
            if (objUsuario.Login(objUsuario))
            {
                /* criar sessão de usuário
                 Session["nome_da_sessao"] = ...  */
                Session["user"] = txtUsuario.Text;
                Session["pass"] = txtSenha.Text;
                Session["nome"] = AcessoBD.tabela.Rows[0][1].ToString();
                /* redireciona para a página do sistema */
                Response.Redirect(url);
            }
            else
            {
                /* caso não encontre o usuário retorna uma mensagem */
                Response.Write(
                    "<script> alert('Usuário não encontrado');</script>");
            }

            /*
            string url;
            url = "sistema.aspx?txtUsuario=" + txtUsuario.Text +
                  "&txtSenha=" + txtSenha.Text;
            Response.Redirect(url);
           */ 
        }
    }
}
/*
 * 
 * Response.Write("<script>alert('teste');</script>");
 string url = "teste.aspx?txtUsuario=" + txtUsuario.Text;
            Response.Redirect(url);
 */
