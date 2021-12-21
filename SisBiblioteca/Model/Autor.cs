using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SisBiblioteca
{
    public class Autor
    {
        #region Campos da classe
        private int codigo;
        private string nome;
        private string nacionalidade;
        private string genero;

        private List<SqlParameter> ListaParametros = new List<SqlParameter>();
        #endregion

        #region Acessores da classe
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Nacionalidade
        {
            get
            {
                return nacionalidade;
            }

            set
            {
                nacionalidade = value;
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
        #endregion

        #region Métodos da classe
        public Boolean _Inserir(Autor objAutor)
        {
            string varSql = "INSERT INTO tb_autor (nome_autor, nac_autor, genero_autor) " +
                            "VALUES (@1, @2, @3)";
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", objAutor.Nome));
            ListaParametros.Add(new SqlParameter("@2", objAutor.Nacionalidade));
            ListaParametros.Add(new SqlParameter("@3", objAutor.Genero));

            return AcessoBD.Manter(varSql, ListaParametros);
        }
        /* Atualizar autor */
        public Boolean _Update(Autor objAutor)
        {
            string varSql = "UPDATE tb_autor SET nome_autor = @1, "+
                            " nac_autor = @2, " + 
                            " genero_autor = @3 " +
                            " WHERE id_autor = @4";
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", objAutor.Nome));
            ListaParametros.Add(new SqlParameter("@2", objAutor.Nacionalidade));
            ListaParametros.Add(new SqlParameter("@3", objAutor.Genero));
            ListaParametros.Add(new SqlParameter("@4", objAutor.Codigo));

            return AcessoBD.Manter(varSql, ListaParametros);
        }

        /* Método para excluir autor */
        public Boolean _Delete(Autor objAutor)
        {
            string varSQL = "DELETE FROM tb_autor WHERE id_autor = @1";
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", objAutor.Codigo));
            return AcessoBD.Manter(varSQL, ListaParametros);
        }

        /* Método para listar autores */
        public DataTable Listar()
        {
            string varSql = "SELECT * FROM tb_autor";

            return AcessoBD.Lista(varSql);
        }
        /* Método Consultar */
        public Boolean consultaAutor(Autor objAutor)
        {
            string varSql = "SELECT * FROM tb_autor WHERE id_autor = @1";
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", objAutor.Codigo));

            return AcessoBD.Consultar(varSql, ListaParametros);
        }

        /* Método para filtrar resultado */
        public DataTable _Filtrar(Autor objAutor)
        {
            string varSql =
                "SELECT * FROM tb_autor WHERE nome_autor LIKE '%" + objAutor.Nome + "%' " + 
                " AND genero_autor LIKE '%" + objAutor.Genero + "%'";
            return AcessoBD.Lista(varSql);
        }
        #endregion

    }
}