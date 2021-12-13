
using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class CidadeController : Controller
    {


        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult AdicionarConfirmacao(Cidade cidade)
        {
            var db = new Contexto();
            var obj = db.Cidade.FirstOrDefault(f => f.IdCidade == cidade.IdCidade);

            if (obj == null)
            {
                db.Cidade.Add(cidade);
            }
            else
            {
                obj.Nome = cidade.Nome;
                obj.UF = cidade.UF;
                db.Cidade.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int IdCidade)
        {
            var db = new Contexto();
            var cidade = db.Cidade.First(item => item.IdCidade == IdCidade);
            return View("Adicionar", cidade);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeCidades = new Contexto().Cidade.ToList();

            return View(listaDeCidades);
        }

        public IActionResult Excluir(int IdCidade)
        {
            var db = new Contexto();
            var cidade = db.Cidade.First(f => f.IdCidade == IdCidade);
            db.Cidade.Remove(cidade);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
