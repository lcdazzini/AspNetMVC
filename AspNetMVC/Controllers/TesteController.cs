using AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "Ativo")]Pessoa pessoa)
        {
			//ViewBag.PessoaInformada = pessoa;
			//return View("Saudacao");

			if (ModelState.IsValid)
			{
				pessoa.Ativo = true;
				return View("Saudacao", pessoa);
			}
			else
			{
				return View(pessoa);
			}

		}
    }
}