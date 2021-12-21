using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SisBiblioteca
{
    public class AcessoBD
    {
        /* Variaveis para conexão e retorno de informação */
        private static string conexao =  @"SERVER=localhost;DATABASE=bd-biblioteca;UID=sa;PWD=senha_do_banco;Trusted_Connection=False;";
        public static DataTable tabela = new DataTable();
        public static string erroBd = "";

        /*
            Método para consulta em tabela com parametros 
            passados pela classe. 
        */
        public static Boolean Consultar(string varSQL, List<SqlParameter> lista)
        {
            /* Conexão com o banco de dados */
            SqlConnection con = new SqlConnection(AcessoBD.conexao);
            /* Conector para enviar função sql e receber retorno */
            SqlDataAdapter adapter = new SqlDataAdapter(varSQL, con);
            /* Enviar instrução de consulta e parametros */
                /* limpa linha de comando */
            adapter.SelectCommand.Parameters.Clear();
            /* carrega lista de parametros */
            adapter.SelectCommand.Parameters.AddRange(
                lista.ToArray<SqlParameter>());
            /* Abrir conexão com o banco */
            con.Open();
            /* Limpar tabela (DataTable) */
            tabela.Clear();
            tabela.Rows.Clear();
            tabela.Columns.Clear();
            /* preenche a tabela com os valores do banco */
            adapter.Fill(tabela);
            /* retorna se encontrou dados para a função */
            if(tabela.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            con.Close();
        }
        /*
            Método para manipular dados na
            tabela do banco de dados 
        */
        public static Boolean Manter(string varSQL, List<SqlParameter> lista)
        {
            try
            {
                // conexão com o banco
                SqlConnection con = new SqlConnection(AcessoBD.conexao);
                // criar comando para o banco de dados
                SqlCommand comando = new SqlCommand(varSQL, con);
                // lista de parametros
                comando.Parameters.Clear();
                comando.Parameters.AddRange(lista.ToArray<SqlParameter>());
                // abrir conexão com o banco
                con.Open();
                // executar comando sql
                comando.ExecuteNonQuery();
                // fechar conexão com o banco
                con.Close();
                // retorna verdadeiro
                return true;                
            }
            catch(Exception ex)
            {
                // retorna falso
                return false;
                // captura mensagem de erro
                erroBd = ex.Message;
            }
        }
        /* Metodo para listar tabela */
        public static DataTable Lista(string varSQL)
        {
            try
            {
                SqlConnection con = new SqlConnection(AcessoBD.conexao);
                SqlDataAdapter adapter = new SqlDataAdapter(varSQL, con);
                /* abre conexão com o banco */
                con.Open();
                /* Limpa campos da tabela */
                tabela.Clear();
                tabela.Rows.Clear();
                tabela.Columns.Clear();
                /* preenche tabela com valores da tabela do banco */
                adapter.Fill(tabela);
                con.Close();
            }
            catch(Exception ex)
            {
                erroBd = ex.Message;
            }
            /* Retorna uma lista em forma de tabela */
            return tabela;
        }
    }
}