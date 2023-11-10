using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Itens_Pedido
    {
        public int IdPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public Produto Produto { get; set; }  
        
        public Itens_Pedido()
        {
            Produto = new Produto();
        }

        public decimal ValorTotal
        {
            get
            {
                return Quantidade * Valor;
            }
        }
    }
}
