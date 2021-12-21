using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisBiblioteca
{
    public partial class cadLivro : System.Web.UI.Page
    {
        /* instancias de classe */
        Autor a = new Autor();
        Livro l = new Livro();

        // variaveis
        string fu = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
        string gen = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            cbAutor();

            if (Request["update"] != null && btnSalvar.Text != "Atualizar")
            {
                l.ISBN = Request["update"].ToString();
                if (l.consultaLivro(l))
                {
                    btnSalvar.Text = "Atualizar";
                }
            }
            else if (Request["delete"] != null)
            {
                l.ISBN = Request["update"].ToString();
                if (l.consultaLivro(l))
                {
                    btnSalvar.Text = "Excluir";
                    btnSalvar.CssClass = "btn btn-cancel";
                    btnCancelar.CssClass = "btn btn-ok";
                }
            }

        }

        public void cbAutor()
        {
            dlAutor.DataSource = a.Listar();
            dlAutor.DataValueField = "id_autor";
            dlAutor.DataTextField = "nome_autor";
            dlAutor.DataBind();
        }

        public void PClasse()
        {
            // dados das caixas de texto
            l.ISBN = txtISBN.Text;
            l.Titulo = txtTitulo.Text;
            l.Sinopse = txtSin.Text;
            l.Autor = Convert.ToInt32(dlAutor.SelectedItem.Value);
            // variavel com novo nome para imagem
            if(fuCapa.HasFile)
            {
                // Captura o nome do arquivo
                string nomeArquivo = Path.GetFileName(fuCapa.FileName);
                // Captura a extensão do arquivo
                string extensao = Path.GetExtension(fuCapa.FileName);
                // salvar imagem com novo nome
                string local = Server.MapPath("~\\capas\\" + fu + extensao);
                fuCapa.SaveAs(local);
                l.Capa = fu + extensao;
            }
            else
            {
                l.Capa = "";
            }
            // generos
            if (rbFic.Checked)
            {
                gen = "fic";
            }
            else if (rbRom.Checked)
            {
                gen = "rom";
            }
            else if (rbPol.Checked)
            {
                gen = "pol";
            }
            else if (rbTer.Checked)
            {
                gen = "ter";
            }
            else if (rbFan.Checked)
            {
                gen = "fan";
            }
            l.Genero = gen;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            PClasse();
            if (l._Insert(l))
            {
                Response.Write("<script> alert('salvou');</script>");
            }
            else
            {
                Response.Write("<script> alert('" + AcessoBD.erroBd + "');</script>");
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {

        }
    }
}