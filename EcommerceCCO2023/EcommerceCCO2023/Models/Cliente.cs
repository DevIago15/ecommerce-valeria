using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCCO2023.Models
{
    public class Cliente
    {
        // atributos = propriedades
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public int statusCli { get; set; }

        public Cliente()
        {

        }
    }
}
