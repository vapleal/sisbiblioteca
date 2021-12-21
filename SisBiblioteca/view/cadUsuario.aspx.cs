using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class cadUsuario : System.Web.UI.Page
    {
        /* instância de classe usuário */
        Usuario ObjUsuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            

            /* Verifica se o campo GET está com valor */
            if(Request["user"] != null)
            {
                ObjUsuario.User = Request["user"].ToString();
                if (ObjUsuario.Consulta(ObjUsuario))
                {
                    txtUsuario.Text = AcessoBD.tabela.Rows[0][2].ToString();
                    txtNome.Text = AcessoBD.tabela.Rows[0][1].ToString();
                    txtSenha.Text = AcessoBD.tabela.Rows[0][3].ToString();

                    drNivelUsu.SelectedIndex = -1;
                    drNivelUsu.Items.FindByValue(
                        AcessoBD.tabela.Rows[0][4].ToString()).Selected = true;

                    txtNome.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtSenha.Enabled = false;

                    btnEnviar.Text = "Excluir";
                    btnEnviar.CssClass = "btn btn-cancel";
                    btnCancelar.CssClass = "btn btn-ok";

                    btnNovo.Enabled = false;
                    btnNovo.CssClass = "btn";

                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../sistema.aspx");
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.User = txtUsuario.Text;

            if (objUsuario.Consulta(objUsuario)) 
            {
                Response.Write(
                    "<script> alert('Usuário já cadastrado!'); </script>");
                txtNome.Text = AcessoBD.tabela.Rows[0][1].ToString();
                txtSenha.Text = AcessoBD.tabela.Rows[0][3].ToString();
                /* volta index da caixa de seleção para "sem valor" */
                drNivelUsu.SelectedIndex = -1;
                /* seleciona o valor de acordo com o "value" da caixa de seleção */
                drNivelUsu.Items.FindByValue(
                    AcessoBD.tabela.Rows[0][4].ToString()).Selected = true;

                txtUsuario.Enabled = false;
                btnEnviar.Text = "Atualizar";
            }

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Nome = txtNome.Text;
            objUsuario.User = txtUsuario.Text;
            objUsuario.Senha = txtSenha.Text;
            objUsuario.Nivel = drNivelUsu.SelectedItem.Value;
            /* Verifica se os campos estão em branco */
            if (txtUsuario.Text == "" || txtNome.Text == "" || txtSenha.Text == "")
            {
                Response.Write(
                "<script> alert('Favor preencher todos os campos.'); </script>"
                );
            }
            /* Caso os campos estejam preenchidos */
            else
            {
                if (btnEnviar.Text == "Atualizar")
                {
                    if(objUsuario._Update(objUsuario))
                    {
                        Response.Write(
                        "<script> alert('Dados atualizados com sucesso!'); </script>"
                        );
                    }
                    else
                    {
                        Response.Write(
                        "<script> alert('Erro ao atualizar: " +
                        AcessoBD.erroBd +
                        "'); </script>"
                        );
                    }
                }
                else if (btnEnviar.Text == "Excluir")
                {
                    if (objUsuario._Delete(objUsuario))
                    {
                        Response.Write(
                        "<script> alert('Usuário excluido com sucesso!'); </script>"
                        );
                        Response.Redirect("./listaUsuario.aspx");
                    }
                    else
                    {
                        Response.Write(
                        "<script> alert('Erro ao excluir: " + 
                        AcessoBD.erroBd + "');</script>"
                        );
                    }
                }
                else
                {
                    if (objUsuario._Inserir(objUsuario))
                    {
                        Response.Write(
                        "<script> alert('Cadastro efetuado com sucesso!'); </script>"
                        );
                    }
                    else
                    {
                        Response.Write(
                        "<script> alert('Erro ao cadastrar: " +
                        AcessoBD.erroBd +
                        "'); </script>"
                        );
                    }
                }
            }
            
            LimpaCampos();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Enabled = true;
            btnEnviar.Text = "Salvar";
        }
    }
}