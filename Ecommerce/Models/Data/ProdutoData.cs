using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Ecommerce.Models.Data
{
    public class ProdutoData
    {
        // método create para cadastrar novos produtos no banco de dados
        public bool Create(Produto produto)
        {
            bool sucesso = false;

            // criar a string SQL para fazer o cadastro de novos produtos
            // ta usando o exec pois é uma função para o banco de dados dar o insert
            string insert = "exec sp_CadProduto '" +
                produto.NomeProd + "', '" +
                produto.Descricao + "', " +
                produto.Quantidade + ", " +
                produto.Valor + ", '" +
                produto.UrlImagem + "', " +
                produto.Categoria.IdCategoria;
            // Exemplo acima: exec sp_CadProduto 'CocaCola','Zero',10,5.0,'caminhodaimagem'

            try
            {
                // criar o objeto para conectar com o BD 
                SqlConnection conexaoBD = Data.ConectarBancoDados();
                // criar um objeto para executar comando SQL
                SqlCommand cmd = new SqlCommand(insert, conexaoBD);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Data.fecharConexaoBancoDados();
                    sucesso = true;
                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n Erro de cadastro do produto" + erro);
            }
            return sucesso;
        }

        //método read para consultar o produto pelo eu id
        public Produto Read(int id)
        {
            // declarar a string SQL para fazer a consulta dos dados do Produto pelo seu id
            string select = "select * from v_Produto" +
                "where idProduto = " + id;

            //conexão com o BD
            SqlConnection conexaoBD = Data.ConectarBancoDados();
            // Comando que executa o SQL no BD
            SqlCommand cmd = new SqlCommand(select, conexaoBD);
            // Execução do select 
            SqlDataReader reader = cmd.ExecuteReader();
            Produto prod = null;
            if (reader.Read())
            {
                prod = new Produto();
                prod.IdProduto = (int)reader["IdProduto"];
                prod.NomeProd = reader["Nome"].ToString();
                prod.Descricao = reader["Descricao"].ToString();
                prod.Quantidade = (int)reader["Qtd"];
                prod.Valor = (double)reader["Valor"];
                if (!reader.IsDBNull(5))
                {
                    prod.UrlImagem = reader["UrlImg"].ToString();
                }
                prod.Categoria.IdCategoria = (int)reader["CatId"];
                prod.Categoria.NomeCategoria = reader["NomeCategoria"].ToString();
            }
            return prod;
        }

        // método uptade para atualizar novos produtos no banco de dados
        public bool Update(Produto produto)
        {
            bool sucesso = false;

            // criar a string SQL para fazer o cadastro de novos produtos
            // ta usando o exec pois é uma função para o banco de dados dar o insert
            string update = "exec sp_UpProduto" +
                produto.IdProduto + ", '" +
                produto.NomeProd + "', '" +
                produto.Descricao + "', " +
                produto.Quantidade + ", " +
                produto.Valor + ", '" +
                produto.UrlImagem + "', " +
                produto.Categoria.IdCategoria;
            try
            {
                // criar o objeto para conectar com o BD 
                SqlConnection conexaoBD = Data.ConectarBancoDados();
                // criar um objeto para executar comando SQL
                SqlCommand cmd = new SqlCommand(update, conexaoBD);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Data.fecharConexaoBancoDados();
                    sucesso = true;
                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("\n\n Erro de Atualização do produto" + erro);
            }
            return sucesso;
        }

        //método delete para deletar o produto pelo eu id
        public bool Delete(int id)
        {
            bool sucesso = false;
            // declarar a string SQL para fazer a consulta dos dados do Produto pelo seu id
            string delete = "delete from Produtos" +
                "where idProduto = " + id;

            //conexão com o BD
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