using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SisBiblioteca
{
    public class Livro
    {
        #region campos da classe
        private string isbn;
        private string titulo;
        private string genero;
        private Int32 autor;
        private string sinopse;
        private string capa;

        private List<SqlParameter> ListaParametros = new List<SqlParameter>();
        private string varSql;
        #endregion

        #region acessores da classe
        public string ISBN
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public int Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Sinopse
        {
            get
            {
                return sinopse;
            }

            set
            {
                sinopse = value;
            }
        }

        public string Capa
        {
            get
            {
                return capa;
            }

            set
            {
                capa = value;
            }
        }
        #endregion

        #region métodos da classe

        public Boolean _Insert(Livro l)
        {
            if (l.Capa == "")
            {
                l.Capa = "0";
            }
            varSql = "INSERT INTO tb_livro (isbn_livro, titulo_livro, gen_livro, sin_livro, capa_livro, pk_autor) " +
                     " VALUES (@1, @2, @3, @4, @5, @6)";
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", l.ISBN));
            ListaParametros.Add(new SqlParameter("@2", l.Titulo));
            ListaParametros.Add(new SqlParameter("@3", l.Genero));
            ListaParametros.Add(new SqlParameter("@4", l.Sinopse));
            ListaParametros.Add(new SqlParameter("@5", l.Capa));
            ListaParametros.Add(new SqlParameter("@6", l.Autor));

            return AcessoBD.Manter(varSql, ListaParametros);
        }

        /* Método Consultar */
        public Boolean consultaLivro(Livro l)
        {
            string varSql = "SELECT l.*, a.* FROM tb_livro l " +
                            "INNER JOIN tb_autor a ON a.id_autor = l.pk_autor " + 
                            "WHERE l.isbn_livro = @1";
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", l.ISBN));

            return AcessoBD.Consultar(varSql, ListaParametros);
        }
        /* Método para listar autores */
        public DataTable Listar()
        {
            string varSql = "SELECT l.capa_livro, l.titulo_livro, a.nome_autor, l.gen_livro, l.isbn_livro FROM tb_livro l " +
                            "INNER JOIN tb_autor a ON a.id_autor = l.pk_autor";

            return AcessoBD.Lista(varSql);
        }
        #endregion
    }
}