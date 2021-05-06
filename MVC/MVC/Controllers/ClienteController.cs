using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            //return RedirectToAction("Contact", "Home");
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View("Insert");
        }

        [HttpPost]
        public IActionResult Save()
        {
            String nome = HttpContext.Request.Form["txtNome"].ToString();
            String email = HttpContext.Request.Form["txtEmail"].ToString();

            ViewBag.nome = nome;
            ViewData["email"] = email;

            return View("Listar");
        }
    }
}