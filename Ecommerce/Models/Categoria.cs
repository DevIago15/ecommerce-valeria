using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Categoria
    {
        // atributos = propriedades
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }

        public Categoria()
        {
            IdCategoria = 0;
            NomeCategoria = null;
        }
    }
}