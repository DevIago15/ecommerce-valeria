using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Pedido
    {
        // atributos = propriedades
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public int Status { get; set; }
        // todo pedido tem pelo menos um item (produto)
        // os itens ficarão em uma lista
        public List<Itens_Pedido> Itens { get; set; } 
            = new List<Itens_Pedido>();
        public decimal TotalPedido
        {
            get
            {
                return Itens.Sum(i => i.ValorTotal);
            }
        }
    }
}
