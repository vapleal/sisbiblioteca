using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class cadAutor : System.Web.UI.Page
    {
        /* Instancia de classe */
        Autor objAutor = new Autor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["update"] != null && btnSalvar.Text != "Atualizar")
            {
                objAutor.Codigo = Convert.ToInt32(Request["update"].ToString());
                if (objAutor.consultaAutor(objAutor))
                {
                    txtNome.Text = AcessoBD.tabela.Rows[0][1].ToString();
                    txtNacionalidade.Text = AcessoBD.tabela.Rows[0][2].ToString();
                    txtGenero.Text = AcessoBD.tabela.Rows[0][3].ToString();

                    btnSalvar.Text = "Atualizar";
                }
            }
            else if(Request["delete"] != null)
            {
                objAutor.Codigo = Convert.ToInt32(Request["delete"].ToString());
                if (objAutor.consultaAutor(objAutor))
                {
                    txtNome.Text = AcessoBD.tabela.Rows[0][1].ToString();
                    txtNacionalidade.Text = AcessoBD.tabela.Rows[0][2].ToString();
                    txtGenero.Text = AcessoBD.tabela.Rows[0][3].ToString();

                    btnSalvar.Text = "Excluir";
                    btnSalvar.CssClass = "btn btn-cancel";
                    btnCancelar.CssClass = "btn btn-ok";
                }
            }
        }

        public void preencheClasse()
        {
            /* Preenche os campos da classe */
            objAutor.Nome = txtNome.Text;
            objAutor.Nacionalidade = txtNacionalidade.Text;
            objAutor.Genero = txtGenero.Text;
            if (Request["update"] != null)
            {
                objAutor.Codigo = Convert.ToInt32(Request["update"].ToString());
            }
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            /* Preenche os campos da classe */
            preencheClasse();

            if(btnSalvar.Text == "Atualizar")
            {
                if (objAutor._Update(objAutor))
                {
                    Response.Write(
                        "<script> alert('Dados atualizados'); </script>"
                    );
                }
                else
                {
                    Response.Write(
                        "<script> alert('Erro ao atualizar'); </script>"
                    );
                }
            }
            else if (btnSalvar.Text == "Salvar")
            {
                /* realiza o processo de inserção de dados */
                if (objAutor._Inserir(objAutor))
                {
                    Response.Write(
                      "<script> alert('Dados salvos com sucesso');</script>"
                    );
                }
                else
                {
                    Response.Write(
                        "<script> alert('Erro ao salvar dados');</script>"
                    );
                }
            }
            else if (btnSalvar.Text == "Excluir")
            {
                objAutor.Codigo = Convert.ToInt32(Request["delete"].ToString());
                if (objAutor._Delete(objAutor))
                {
                    Response.Write(
                       "<script> "+
                       " alert('Autor excluido com sucesso!'); "+
                       " location.href = 'listaAutor.aspx'; " + 
                       "</script>"
                    );
                 //   Response.Redirect("listaAutor.aspx");
                }
                else
                {
                    Response.Write(
                        "<script> alert('Erro ao excluir'); </script>"
                       );
                }

            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Atualizar" || btnSalvar.Text == "Excluir")
            {
                Response.Redirect("listaAutor.aspx");
            }
            else
            {
                Response.Redirect("sistema.aspx");
            }
        }
    }
}