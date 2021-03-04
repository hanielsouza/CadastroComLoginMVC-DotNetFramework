using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroComLogin.Models
{
    public class Cadastro
    {
       [Required(ErrorMessage ="Nome obrigatório")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "Usuário obrigatório")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirmação obrigatória")]
        public string ConfirmaçãoSenha { get; set; }
        [Required(ErrorMessage ="Data obrigatória")]
        public DateTime DataNascimento { get; set; }
    }
}