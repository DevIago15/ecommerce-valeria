using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Ecommerce.Models.Data
{
    public class CategoriaData
    {
        // Crud da categoria 
        // implementar o metodo read para consultar todos os dados de todas as categorias armazenadas no banco de dados 
        // este método retorna uma lista com todas as categorias cadastradas
        public List<Categoria> Read()
        {
            // instanciar a lista 
            List<Categoria> lista = new List<Categoria>();

            // criar string sql para co nsultar todas as categorias
            string select = "select * from Categoria";

            // declaração de objeto de conexão com o banco de dados 
            SqlConnection conectarBD = Data.ConectarBancoDados();

            // criar objeto para executar os comandos SQL no banco de dados 
            SqlCommand cmd = new SqlCommand(select, conectarBD);
            // criando o objeto reader

            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            // percorrer a tabela resultante e acessar cada elemento
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria = (int)reader["idCategoria"];
                categoria.NomeCategoria = reader["categoria"].ToString();
                lista.Add(categoria);
            }
            return lista;
        }
    }
}