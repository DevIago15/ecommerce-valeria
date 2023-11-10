using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Categoria
    {
        // artibutos = propriedades
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }

        // construtor
        public Categoria()
        {
            IdCategoria = 0;
            NomeCategoria = null;
        }
    }
}
