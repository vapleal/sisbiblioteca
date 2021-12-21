using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SisBiblioteca
{
    public class Usuario
    {
        #region campos da classe
        private int codigo;
        private string user;
        private string senha;
        private string nome;
        private string nivel;

        private List<SqlParameter> lista = 
                        new List<SqlParameter>();
        #endregion

        #region acessores da classe
        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
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

        public string Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }
        #endregion

        #region metodos da classe
        public Boolean Login(Usuario u)
        {
            /* Instrução sql para consulta */
            string varSql = "EXECUTE pr_login_usu @1, @2";
            //"SELECT * FROM tb_usuario WHERE login_usu = @1 AND senha_usu = @2";
            /* limpar lista de parametros */
            lista.Clear();
            /* adicionar parametros para a consulta */
            lista.Add(new SqlParameter("@1", u.User));
            lista.Add(new SqlParameter("@2", u.Senha));
            /* chamada da função que faz a consulta da dados no banco */
            return AcessoBD.Consultar(varSql, lista);

            /* Boolean login = false;
            foreach(Usuario user in Usuarios())
            {
                if (user.User == u.User && user.Senha == u.Senha)
                {
                    login = true;
                    break;
                }
            }
           return login; */
        }

        public Boolean Consulta(Usuario usuario)
        {
            string varSql = "SELECT * FROM tb_usuario WHERE login_usu = @1";
            lista.Clear();
            lista.Add(new SqlParameter("@1", usuario.User));
            return AcessoBD.Consultar(varSql, lista);
        }

        /*
            objeto do tipo List<>: listagem de valores
                - texto
                - numero
                - classe 
           ex: List<string> [nome] = new List<string>()

            {livro, autor | livro, autor | etc...}
            List<Usuario> = dados de usuario

        */
        public List<Usuario> Usuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario { User = "admin",
                                    Senha = "123",
                                    Nome = "Administrador do Sistema" });
            lista.Add(new Usuario { User = "user1",
                                    Senha = "456",
                                    Nome = "Usuario Numero Um"});
            lista.Add(new Usuario { User = "user2",
                                    Senha = "789",
                                    Nome = "Usuario Numero Dois"});
            return lista;
        }

        public string NomeUsuario(Usuario u)
        {
            string nome = "";
            foreach(Usuario user in Usuarios())
            {
                if(user.User == u.User && user.Senha == u.Senha)
                {
                    nome = user.Nome;
                    break;
                }
            }
            return nome;
        }

        /* Método para cadastrar um usuário */
        public Boolean _Inserir(Usuario objUsuario)
        {
            string varSql = "INSERT INTO tb_usuario " + 
                            " (nome_usu, login_usu, senha_usu, nivel_usu)" + 
                            "VALUES (@1, @2, @3, @4)";
            lista.Clear();
            lista.Add(new SqlParameter("@1", objUsuario.Nome));
            lista.Add(new SqlParameter("@2", objUsuario.User));
            lista.Add(new SqlParameter("@3", objUsuario.Senha));
            lista.Add(new SqlParameter("@4", objUsuario.Nivel));

            return AcessoBD.Manter(varSql, lista);
        }
        /* Método para alterar dados de usuário */
        public Boolean _Update(Usuario objUsuario)
        {
            string varSql = "UPDATE tb_usuario SET " + 
                            "nome_usu = @1, " + 
                            "senha_usu = @2, " + 
                            "nivel_usu = @3 " + 
                            "WHERE login_usu = @4";
            lista.Clear();
            lista.Add(new SqlParameter("@1", objUsuario.Nome));
            lista.Add(new SqlParameter("@2", objUsuario.Senha));
            lista.Add(new SqlParameter("@3", objUsuario.Nivel));
            lista.Add(new SqlParameter("@4", objUsuario.User));

            return AcessoBD.Manter(varSql, lista);
        }
        /* Método para excluir usuário */
        public Boolean _Delete(Usuario objUsuario)
        {
            string varSql = "DELETE FROM tb_usuario WHERE login_usu = @1";
            lista.Clear();
            lista.Add(new SqlParameter("@1", objUsuario.User));

            return AcessoBD.Manter(varSql, lista);
        }
        /* Listar usuários */
        public DataTable Listar()
        {
            string varSql = "SELECT nome_usu 'Nome do Usuário', "+
                            " login_usu 'Login do Usuário'," + 
                            " nivel_usu 'Nível de acesso' "+
                            "FROM tb_usuario";

            return AcessoBD.Lista(varSql);
        }
        /* Filtrar usuários */
        public DataTable filtrarLista(Usuario objUsuario)
        {
            string varSql = "SELECT nome_usu 'Nome do Usuário', " +
                            " login_usu 'Login do Usuário'," +
                            " nivel_usu 'Nível de acesso' " +
                            "FROM tb_usuario " + 
                            " WHERE nome_usu LIKE '%" + objUsuario.Nome + "%' " +
                            " AND login_usu LIKE '%" + objUsuario.User + "%'";

            return AcessoBD.Lista(varSql);
        }
        #endregion
    }
}