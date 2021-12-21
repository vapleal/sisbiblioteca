using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class consultaAutor : System.Web.UI.Page
    {
        /* Instancia de classe autor */
        Autor objAutor = new Autor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PreencheGrid("", "");
            }
        }

        public void PreencheGrid(string nome, string genero)
        {
            // Atribuir valores na classe
            objAutor.Nome = nome;
            objAutor.Genero = genero;
            // criar tabela para o grid
            DataTable objTabela = new DataTable();
            // colunas do grid
            objTabela.Columns.Add("Nome do Autor");
            objTabela.Columns.Add("Nacionalidade");
            objTabela.Columns.Add("Gênero Literario");
            // utilizar filtro
            for (int i = 0; i < objAutor._Filtrar(objAutor).Rows.Count; i++)
            {
                // cria uma nova linha
                DataRow objLinha = objTabela.NewRow();
                // atribui os valores nas colunas
                objLinha[0] = objAutor._Filtrar(objAutor).Rows[i][1].ToString();
                objLinha[1] = objAutor._Filtrar(objAutor).Rows[i][2].ToString();
                objLinha[2] = objAutor._Filtrar(objAutor).Rows[i][3].ToString();
                // insere a nova linha na tabela
                objTabela.Rows.Add(objLinha);
            }
            dgAutor.DataSource = objTabela;
            dgAutor.DataBind();
        }

        protected void txtNome_TextChanged(object sender, EventArgs e)
        {
            PreencheGrid(txtNome.Text, txtGen.Text);
        }

        protected void txtGen_TextChanged(object sender, EventArgs e)
        {
            PreencheGrid(txtNome.Text, txtGen.Text);
        }

        protected void dgAutor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgAutor.PageIndex = e.NewPageIndex;
            PreencheGrid(txtNome.Text, txtGen.Text);
        }
    }
}