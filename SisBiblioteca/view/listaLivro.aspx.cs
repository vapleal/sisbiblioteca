using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class listaLivro : System.Web.UI.Page
    {
        /* Instancia de livro */
        Livro objLivro = new Livro();

        protected void Page_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        public void PreencheGrid()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Capa");
            dataTable.Columns.Add("Título");
            dataTable.Columns.Add("Autor");
            dataTable.Columns.Add("Gênero Literário");
            dataTable.Columns.Add("ISBN");
            for (int i = 0; i < objLivro.Listar().Rows.Count; i++)
            {
                DataRow linha = dataTable.NewRow();
                if (objLivro.Listar().Rows[i][0].ToString() == "0")
                {
                    linha[0] = "../imagens/default.jpg";
                }
                else
                {
                    linha[0] = "../imagens/" + objLivro.Listar().Rows[i][0].ToString();
                }
                linha[1] = objLivro.Listar().Rows[i][1].ToString();
                linha[2] = objLivro.Listar().Rows[i][2].ToString();
                linha[3] = objLivro.Listar().Rows[i][3].ToString();
                linha[4] = objLivro.Listar().Rows[i][4].ToString();
                dataTable.Rows.Add(linha);
            }
            dgLivros.DataSource = dataTable;
            dgLivros.DataBind();
        }

        protected void dgLivros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgLivros.PageIndex = e.NewPageIndex;
            dgLivros.DataBind();
        }
    }
}