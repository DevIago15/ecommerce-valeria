using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Ecommerce.Models.Data
{
    public class Data
    {
        // static entra na memoria uma vez e fica pra sempre (nao é necessario ficar iniciando a variavel na memoria)
        private static string stringConexao = @"Data source = IAGO\SQLEXPRESS; Initial Catalog = nome_db; Integrated Security = true;";


        //  usando aut do SQLServer
        //
        //  private static string stringConexao = @"Data source = IAGO\SQLEXPRESS; Initial Catalog = nome_db; USER ID = xx; Password = yy;";

        // declarando o objeto da conexao no banco de dados e inicializando
        private static SqlConnection conexaoBD = null;

        // implmentando um metodo para fazer a conexao no banco de dados
        public static SqlConnection ConectarBancoDados()
        {
            // instanciando o objeto conexaoBD e passando a string de conexao que ele deve fazer
            conexaoBD = new SqlConnection(stringConexao);

            // tentando se conectar no banco - deu ok exibe msg de ok, ou verifica se deu erro (null) e printa o erro na tela
            try
            {
                conexaoBD.Open();
                Console.WriteLine("CONEXÃO OK!");
            } 
            catch(SqlException error)
            {
                conexaoBD = null;
                Console.WriteLine("ERRO: ERRO NA CONEXÃO COM O BANCO DE DADOS: " + error);
            }

            // retornando o try catch da conexaoDB (se der bom ou ruim)
            return conexaoBD;
        }

        // implementando um metodo para fechar o banco de dados (se deixar aberto, fica vulneravel)
        public static void fecharConexaoBancoDados()
        {
            // se conexaoBD é diferente de nulo, fecha o banco de dados
            if (conexaoBD != null)
            {
                conexaoBD.Close();
            }
        }
    }
}