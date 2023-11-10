using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models.Data
{
    // CRUD DO PRODUTO
    public class ProdutoData
    {
        // método create para cadastrar novos produtos
        // no banco de dados
        public bool Create(Produto produto)
        {
            bool sucesso = false;

            // criar a string SQL para fazer o cadastro
            // de novos produtos
            string insert = "exec sp_CadProduto '" +
                produto.NomeProd + "', '" +
                produto.Descricao + "', " +
                produto.Quantidade + ", " +
                produto.Valor + ", '" +
                produto.UrlImagem + "', " +
                produto.Status +", " +
                produto.Categoria.IdCategoria;

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
        public List<Produto> Read()
        {
            // daclaração da lista
            List<Produto> lista = null;

            // declarar a string SQL para fazer a consulta
            // dos dados de todos os Produto 
            string select = "select * from v_Produto";
            
            try
            {                
                // Conexão com  o BD
                SqlConnection conexaoBD = Data.ConectarBancoDados();
                // Comando que executa o SQL no BD
                SqlCommand cmd = new SqlCommand(select, conexaoBD);
                // Execução do select
                SqlDataReader reader = cmd.ExecuteReader();

                // instancão a lista
                lista = new List<Produto>();

                while (reader.Read())
                {                                      
                    Produto prod = new Produto();
                    prod.IdProduto = (int)reader["idProduto"];
                    prod.NomeProd = reader["NomeProd"].ToString();
                    prod.Descricao = reader["Descricao"].ToString();
                    prod.Quantidade = (int)reader["QtdProd"];
                    prod.Valor =  (decimal) reader["Valor"];
                    if (!reader.IsDBNull(5))
                    {
                        prod.UrlImagem = reader["UrlImg"].ToString();
                    }
                    prod.Categoria.IdCategoria = (int)reader["IdCategoria"];
                    prod.Categoria.NomeCategoria = reader["Categoria"].ToString();
                    lista.Add(prod);
                }
            } 
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n\n Erro Produto " + erro + "\n\n\n");
            }
          
            return lista;
        }



        // método read para consultar o produto pelo seu id
        public Produto Read(int id)
        {
            // declarar a string SQL para fazer a consulta
            // dos dados do Produto pelo seu id
            string select = "select * from v_Produto " +
                "where idProduto = " + id;
            // Conexão com  o BD
            SqlConnection conexaoBD = Data.ConectarBancoDados();
            // Comando que executa o SQL no BD
            SqlCommand cmd = new SqlCommand(select, conexaoBD);
            // Execução do select
            SqlDataReader reader = cmd.ExecuteReader();
            Produto prod = null;
            if(reader.Read())
            {
                prod = new Produto();
                prod.IdProduto = (int)reader["idProduto"];
                prod.NomeProd = reader["NomeProd"].ToString();
                prod.Descricao = reader["Descricao"].ToString();
                prod.Quantidade = (int)reader["QtdProd"];
                prod.Valor = (decimal)reader["Valor"];
                if (!reader.IsDBNull(5))
                {
                    prod.UrlImagem = reader["UrlImg"].ToString();
                }
                prod.Status = (int)reader["Status"];
                prod.Categoria.IdCategoria = (int)reader["IdCategoria"];
                prod.Categoria.NomeCategoria = reader["Categoria"].ToString();

            }
            return prod;
        }

        // método update para atualizar dados do produto
        // no banco de dados
        public bool Update(Produto produto)
        {
            bool sucesso = false;

            // criar a string SQL para fazer o update
            // de produto
            string update = "exec sp_UpProduto " +
                produto.IdProduto + ", '" +
                produto.NomeProd + "', '" +
                produto.Descricao + "', " +
                produto.Quantidade + ", " +
                produto.Valor + ", '" +
                produto.UrlImagem + "', " +
                produto.Status + ", " +
                produto.Categoria.IdCategoria;
            try
            {
                // criar um objeto para conectar com o BD
                SqlConnection conexaoBD = Data.ConectarBancoDados();
                // criar um objeto para executar o comando SQL
                SqlCommand cmd = new SqlCommand(update, conexaoBD);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Data.fecharConexaoBancoDados();
                    sucesso = true;
                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n Erro de atualização do Produto " + erro);
            }
            return sucesso;
        }

        // método delete para excluir um produto pelo id
        public bool Delete(int id)
        {
            bool sucesso = false;
            // declarar a string SQL para fazer a consulta
            // dos dados do Produto pelo seu id
            string delete = "delete from Produtos " +
                "where idProduto = " + id;
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
