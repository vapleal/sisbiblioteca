using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class listaAutor : System.Web.UI.Page
    {
        /* Instancia de autor */
        Autor objAutor = new Autor();

        protected void Page_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        public void PreencheGrid()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Código");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Nacionalidade");
            dataTable.Columns.Add("Gênero Literário");
            for(int i = 0; i < objAutor.Listar().Rows.Count; i++)
            {
                DataRow linha = dataTable.NewRow();
                linha[0] = objAutor.Listar().Rows[i][0].ToString();
                linha[1] = objAutor.Listar().Rows[i][1].ToString();
                linha[2] = objAutor.Listar().Rows[i][2].ToString();
                linha[3] = objAutor.Listar().Rows[i][3].ToString();
                dataTable.Rows.Add(linha);
            }
            dgAutores.DataSource = dataTable;
            dgAutores.DataBind();
        }

        protected void dgAutores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgAutores.PageIndex = e.NewPageIndex;
            dgAutores.DataBind();
        }
    }
}