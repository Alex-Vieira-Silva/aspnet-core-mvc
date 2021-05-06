using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Somar()
        {
            try
            {
                int n1 = Convert.ToInt32(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt32(HttpContext.Request.Form["txtN2"].ToString());
                ViewBag.Resultado = (n1 + n2).ToString();
            }
            catch (Exception ex)
            {
                ViewBag.Resultado = "Ocorreu um erro!";
            }
            

            return View("Index");
        }

        [HttpPost]
        public IActionResult Subtrair()
        {
            try
            {
                int n1 = Convert.ToInt32(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt32(HttpContext.Request.Form["txtN2"].ToString());
                ViewBag.Resultado = (n1 - n2).ToString();
            }
            catch (Exception ex)
            {
                ViewBag.Resultado = "Ocorreu um erro!";
            }


            return View("Index");
        }

        [HttpPost]
        public IActionResult Multiplicar()
        {
            try
            {
                int n1 = Convert.ToInt32(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt32(HttpContext.Request.Form["txtN2"].ToString());
                ViewBag.Resultado = (n1 * n2).ToString();
            }
            catch (Exception ex)
            {
                ViewBag.Resultado = "Ocorreu um erro!";
            }


            return View("Index");
        }

        [HttpPost]
        public IActionResult Dividir()
        {
            try
            {
                int n1 = Convert.ToInt32(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt32(HttpContext.Request.Form["txtN2"].ToString());
                ViewBag.Resultado = (n1 / n2).ToString();
            }
            catch (Exception ex)
            {
                ViewBag.Resultado = "Ocorreu um erro!";
            }


            return View("Index");
        }
    }
}