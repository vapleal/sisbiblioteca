using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class listaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Instância de classe (Usuario) */
            Usuario objUsuario = new Usuario();
            /* Objeto DataTable */
            DataTable objDataTable = new DataTable();
            /* Colunas para o objDataTable */
            objDataTable.Columns.Add("Nome do Usuário");
            objDataTable.Columns.Add("Login do Usuário");
            objDataTable.Columns.Add("Nível de acesso");
            /* Colocar os dados na nova tabela */
            for(int i = 0; i <= objUsuario.Listar().Rows.Count - 1; i++)
            {
                /* Cria uma nova linha para os dados */
                DataRow objLinha = objDataTable.NewRow();
                /* adiciona os dados em suas colunas */
                objLinha[0] = objUsuario.Listar().Rows[i][0].ToString();
                objLinha[1] = objUsuario.Listar().Rows[i][1].ToString();
                if(objUsuario.Listar().Rows[i][2].ToString() == "0")
                {
                    objLinha[2] = "Administrador";
                }
                else if (objUsuario.Listar().Rows[i][2].ToString() == "1")
                {
                    objLinha[2] = "Atendente";
                }
                else
                {
                    objLinha[2] = "Aluno";
                }
                /* Adiciona a linha com os dados na tabela */
                objDataTable.Rows.Add(objLinha);
            }
            /* Define a fonte de dados (dataSource) para o grid */
            dgUsuarios.DataSource = objDataTable;
            /* Carrega os dados no grid */
            dgUsuarios.DataBind();
        }

        protected void dgUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgUsuarios.PageIndex = e.NewPageIndex;
            dgUsuarios.DataBind();
        }
    }
}