using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Produto
    {
        // atributos = propriedades
        public int IdProduto { get; set; }
        public string NomeProd { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string UrlImagem { get; set; }
        public int Status { get; set; }
        public Categoria Categoria { get; set; }

        // construtor
        public Produto()
        {
            Categoria = new Categoria();
        }
    }
}
