using CadastroComLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroComLogin.Controllers
{
    public class CadastrarController : Controller
    {
        List<Cadastro> cadastros = new List<Cadastro> { 
            new Cadastro { Usuario = "teste", NomeCompleto = "Teste Sousa", DataNascimento = DateTime.Parse("28-10-1996"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Maria", NomeCompleto = "Maria Santos", DataNascimento = DateTime.Parse("10-06-1978"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Juneide", NomeCompleto = "Juneide Cristina", DataNascimento = DateTime.Parse("11-05-2000"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Lenora", NomeCompleto = "Lenora Maria", DataNascimento = DateTime.Parse("05-02-1958"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Marcelo", NomeCompleto = "Marcelo Pereira", DataNascimento = DateTime.Parse("03-02-1988"), Senha = "123456", ConfirmaçãoSenha = "123456" }
        };
      

        // GET: Cadastrar
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Cadastrar(Cadastro pCadastro)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Cadastro realizado com sucesso";
                cadastros.Add(pCadastro);
            }
            else
            {
                return View("Index");
            }
            return View(cadastros);
        }
    }
}