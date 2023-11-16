using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models.Data
{
    // CRUD DO PRODUTO
    public class ClienteData
    {
        // método create para cadastrar novos produtos
        // no banco de dados
        public bool Create(Cliente cliente)
        {
            bool sucesso = false;

            // criar a string SQL para fazer o cadastro
            // de novos produtos
            string insert = "exec sp_CadCliente '" +
                 cliente.Nome + "', '" +
                 cliente.Foto + "', '" +
                 cliente.Email + "', '" +
                 cliente.Senha + "', '" +
                 cliente.statusCli + "'";

            try
            {
                // criar um objeto para conectar com o BD
                SqlConnection conexaoBD = Data.ConectarBancoDados();
                // criar um objeto para executar o comando SQL
                SqlCommand cmd = new SqlCommand(insert, conexaoBD);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Data.fecharConexaoBancoDados();
                    sucesso = true;
                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n Erro de cadastro do Produto " + erro);
            }
            return sucesso;
        }

        // método read para consultar todos os produtos 
        public List<Cliente> Read()
        {
            // daclaração da lista
            List<Cliente> lista = null;

            // declarar a string SQL para fazer a consulta
            // dos dados de todos os Produto 
            string select = "select * from v_Cliente";
            
            try
            {                
                // Conexão com  o BD
                SqlConnection conexaoBD = Data.ConectarBancoDados();
                // Comando que executa o SQL no BD
                SqlCommand cmd = new SqlCommand(select, conexaoBD);
                // Execução do select
                SqlDataReader reader = cmd.ExecuteReader();

                // instancão a lista
                lista = new List<Cliente>();

                while (reader.Read())
                {                                      
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = (int)reader["idCliente"];
                    cliente.Nome = reader["nomeCli"].ToString();
                    cliente.Email = reader["email"].ToString();
                    cliente.Senha = reader["senha"].ToString();
                    cliente.statusCli = (int)reader["status"];

                    if (!reader.IsDBNull(5))
                    {
                        cliente.Foto = reader["foto"].ToString();
                    }
                    lista.Add(cliente);
                }
            } 
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n\n Erro Cliente " + erro + "\n\n\n");
            }
          
            return lista;
        }



        // método read para consultar o produto pelo seu id
        public Cliente Read(int id)
        {
            // declarar a string SQL para fazer a consulta
            // dos dados do Produto pelo seu id
            string select = "select * from v_Cliente " +
                "where idCliente = " + id;
            // Conexão com  o BD
            SqlConnection conexaoBD = Data.ConectarBancoDados();
            // Comando que executa o SQL no BD
            SqlCommand cmd = new SqlCommand(select, conexaoBD);
            // Execução do select
            SqlDataReader reader = cmd.ExecuteReader();
            Cliente cliente = null;
            if(reader.Read())
            {
                cliente = new Cliente();
                cliente.IdCliente = (int)reader["idCliente"];
                cliente.Nome = reader["nomeCli"].ToString();
                cliente.Email = reader["email"].ToString();
                cliente.Senha = reader["senha"].ToString();

                if (!reader.IsDBNull(5))
                {
                    cliente.Foto = reader["foto"].ToString();
                }
                cliente.statusCli = (int)reader["Status"];

            }
            return cliente;
        }

        // método update para atualizar dados do produto
        // no banco de dados
        public bool Update(Cliente cliente)
        {
            bool sucesso = false;

            // criar a string SQL para fazer o update de produto
            string update = "EXEC sp_UpCliente @IdCliente, @Nome, @Foto, @Email, @Senha, @statusCli";

            try
            {
                using (SqlConnection conexaoBD = Data.ConectarBancoDados())
                {
                    using (SqlCommand cmd = new SqlCommand(update, conexaoBD))
                    {
                        // Adicionar parâmetros
                        cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                        cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                        cmd.Parameters.AddWithValue("@Foto", cliente.Foto);
                        cmd.Parameters.AddWithValue("@Email", cliente.Email);
                        cmd.Parameters.AddWithValue("@Senha", cliente.Senha);
                        cmd.Parameters.AddWithValue("@statusCli", cliente.statusCli);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            sucesso = true;
                        }
                    } // O bloco using automaticamente chama o Dispose, que inclui o fechamento da conexão.
                } // Outro bloco using para garantir que a conexão seja fechada, mesmo em caso de exceção.
            }
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n Erro de Atualização do Cliente " + erro);
            }

            return sucesso;
        }

        // método delete para excluir um produto pelo id
        public bool Delete(int id)
        {
            bool sucesso = false;
            // declarar a string SQL para fazer a consulta
            // dos dados do Produto pelo seu id
            string delete = "DELETE FROM Clientes " +
                "WHERE idCliente = " + id;
            // Conexão com  o BD
            SqlConnection conexaoBD = Data.ConectarBancoDados();
            // Comando que executa o SQL no BD
            SqlCommand cmd = new SqlCommand(delete, conexaoBD);
            
            if (cmd.ExecuteNonQuery() == 1)
            {
                Data.fecharConexaoBancoDados();
                sucesso = true;
            }
            return sucesso;
        }
    }
}
