using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Cliente
    {
        // atributos = propriedades
        public int IdCliente    { get; set; }
        public string Nome      { get; set; }
        public string Foto      { get; set; }
        public string Email     { get; set; }
        public string Senha     { get; set; }
        public int statusCli    { get; set; }

        public Cliente()
        {

        }
    }
}
