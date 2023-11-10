using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models.Data
{
    public class CategoriaData 
    {
        // CRUD DA CATEGORIA
        // implementar o método Read para consultar
        // todos os dados de todas as categorias
        // armazenadas no Banco de Dados
        // Esse método retorna uma lista com todas as
        // categorias cadastradas
        public List<Categoria> Read()
        {
            // instanciar a lista
            List<Categoria> lista = new List<Categoria>();

            // criar a string SQL para consultar todas as 
            // categorias
            string select = "select * from Categorias";

            // declaração de objeto de conexão com o 
            // Banco de dados
            SqlConnection conectarBD = Data.ConectarBancoDados();

            // criar um objeto para executar os comandos 
            // SQL no Banco de Dados
            SqlCommand cmd = new SqlCommand(select, conectarBD);
            // criando o objeto reader para executar o select
            SqlDataReader reader;
            // execução do select no Banco de dados
            reader = cmd.ExecuteReader();

            // percorrer a tabela resultante e acessar
            // cada elemento da tabela
            while(reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria   = (int) reader["idCategoria"];
                categoria.NomeCategoria = reader["Categoria"].ToString();
                lista.Add(categoria);
            }
            return lista;
        }
    }
}
