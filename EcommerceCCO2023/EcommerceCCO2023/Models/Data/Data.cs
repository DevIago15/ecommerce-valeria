using System;
using System.Data.SqlClient;

namespace EcommerceCCO2023.Models.Data
{
    public class Data
    {
        
        // conexão usando autenticação do Windows
        private static string stringConexao =
            @"Data source = IAGO\SQLEXPRESS;
            Initial Catalog = Lanches_LP_CCO2023;
            Integrated Security = true;";

        // conexão usando autenticação do SQL Server
        /*
        private static string stringConexao = 
            @"Data source = localhost; 
            Initial Catalog = Lanches_LP_CCO2023; 
            User ID = computacao; 
            Password = aa11++--;";
       */

        // declaração do objeto conexaoBD e inicializando
        // com null
        private static SqlConnection conexaoBD = null;

        // implementando um método para fazer a conwxão
        // com o Banco de Dados
        public static SqlConnection ConectarBancoDados()
        {
            // Instanciando o objeto conexaoBD e passando
            // para o Construtor da classe SqlConnection
            // o parâmetro stringSQL para fazer a
            // conexão com o Banco de Dados
            conexaoBD = new SqlConnection(stringConexao);

            try
            {
                // Abrir o Banco de Dados
                conexaoBD.Open();
                Console.WriteLine("Conexão OK");
            }
            catch (SqlException erro)
            {  
                // ocorrreu erro na conexão com o Banco de Dados
                conexaoBD = null;                
                Console.WriteLine("Conexão Error :" + erro);
            }
            
            // retorna a conexão com Banco de Dados se deu certo
            // ou retorna null se não foi possível conectar com
            // o Banco de Dados
            return conexaoBD;
        }

        public static void fecharConexaoBancoDados()
        {
            if (conexaoBD != null)
            {
                conexaoBD.Close();
            }
        }
    }
}
