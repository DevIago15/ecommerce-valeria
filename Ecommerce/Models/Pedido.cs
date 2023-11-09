using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Pedido
    {
        // atributos = propriedades
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public int Status { get; set; }
        public List<Itens_Pedido> Itens { get; set; } = new List<Itens_Pedido>();
        public decimal TotalPedido
        {
            get
            {
                return Itens.Sum(i => i.ValorTotal); // notacao LAMBDAS pro i variando de 0 até o fim da lista e fazer a soma (poderia ser trocado por um for passando pela lista e somando tudo
            }
        }


    }
}