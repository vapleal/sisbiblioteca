using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class consultaUsuario : System.Web.UI.Page
    {
        Usuario objUsuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PreencheGrid("", "");
            }
        }

        /* Método para preencher grid */
        public void PreencheGrid(string nome, string usuario)
        {
            /* dados para consulta */
            objUsuario.Nome = nome;
            objUsuario.User = usuario;
            /* tabela de dados local (datatable) */
            DataTable dataTable = new DataTable();
            /* colunas da tabela */
            dataTable.Columns.Add("Nome Usuário");
            dataTable.Columns.Add("Usuário");
            dataTable.Columns.Add("Nível Acesso");
            /* preencher tabela local */
            for(int i = 0; i < objUsuario.filtrarLista(objUsuario).Rows.Count; i++)
            {
                /* abre uma nova linha na tabela */
                DataRow linha = dataTable.NewRow();
                /* acrescenta as informações nas colunas da tabela */
                linha[0] = objUsuario.filtrarLista(objUsuario).Rows[i][0].ToString();
                linha[1] = objUsuario.filtrarLista(objUsuario).Rows[i][1].ToString();
                linha[2] = objUsuario.filtrarLista(objUsuario).Rows[i][2].ToString();
                /* insere nova linha no dataTable */
                dataTable.Rows.Add(linha);
            }
            /* preenche o grid */
            dgUsuario.DataSource = dataTable;
            dgUsuario.DataBind();
        }

        protected void txtNome_TextChanged(object sender, EventArgs e)
        {
            PreencheGrid(txtNome.Text, txtUsuario.Text);
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            PreencheGrid(txtNome.Text, txtUsuario.Text);
        }

         protected void dgUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgUsuario.PageIndex = e.NewPageIndex;
            PreencheGrid(txtNome.Text, txtUsuario.Text);
        }
    }
}