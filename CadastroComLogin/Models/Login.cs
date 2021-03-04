using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroComLogin.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Usuário obrigatório")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Data obrigatório")]
        public DateTime DataNascimento { get; set; }

    }
}