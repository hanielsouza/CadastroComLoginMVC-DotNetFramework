using CadastroComLogin.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroComLogin.Controllers
{

   
    public class HomeController : Controller
    {
        List<Cadastro> cadastros = new List<Cadastro> {
            new Cadastro { Usuario = "teste", NomeCompleto = "Teste Sousa", DataNascimento = DateTime.Parse("28-10-1996"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Maria", NomeCompleto = "Maria Santos", DataNascimento = DateTime.Parse("10-06-1978"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Juneide", NomeCompleto = "Juneide Cristina", DataNascimento = DateTime.Parse("11-05-2000"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Lenora", NomeCompleto = "Lenora Maria", DataNascimento = DateTime.Parse("05-02-1958"), Senha = "123456", ConfirmaçãoSenha = "123456" },
            new Cadastro { Usuario = "Marcelo", NomeCompleto = "Marcelo Pereira", DataNascimento = DateTime.Parse("03-02-1988"), Senha = "123456", ConfirmaçãoSenha = "123456" }
        };

        public ActionResult Index()
        {
            if (Session["ErrorLogin"]!= null)
            {
                ViewBag.Error = Session["ErrorLogin"].ToString();
                Session.Remove("ErrorLogin");
            }
            return View();
        }

        public ActionResult Login(Login pLogin)
        
        {
            if (ModelState.IsValid)
            {
                if(cadastros.Any(x=> x.Usuario == pLogin.Usuario && x.Senha == pLogin.Senha && x.DataNascimento == pLogin.DataNascimento))
                Session["User"] = pLogin.Usuario;
                else
                {
                    //Jogar uma mensagem para a tela
                    Session["ErrorLogin"] = "Usuário ou senha inválido";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                    ModelState.AddModelError("Usuario", "O campo nome é obrigatório");
                
                    ModelState.AddModelError("Senha", "O campo nome é obrigatório");

                return View("Index");
            }

           return RedirectToAction("Index","Cadastrar");
        }

        public ActionResult Sair()
        {
            Session.Remove("User");
            return RedirectToAction("Index");
        }
    }
}