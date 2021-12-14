using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using PROJETO01.validations;
using System.Collections.Generic;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class BarbeiroController : Controller
    {
        public IActionResult Index(
          int IdBarbeiro, 
          string Nome, 
          string cpf, 
          float PrecoCorte,
          string Telefone,
          int IdEspecialidade
          )
        {
            var obj = new Barbeiro();
            obj.IdBarbeiro = IdBarbeiro;
            obj.Nome = Nome;
            obj.cpf = cpf;
            obj.PrecoCorte = PrecoCorte;
            obj.Telefone = Telefone;
            obj.IdEspecialidade = IdEspecialidade;

            return View(obj);
        }
        [HttpGet]
        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Especialidade = db.EspecialidadeB.ToList();
            return View();
        }

        public IActionResult AdicionarConfirmacao(Barbeiro barbeiro)

        {
            BarbeiroValidation produtoValidation = new BarbeiroValidation();

            var validacao = produtoValidation.Validate(barbeiro);


            if (!validacao.IsValid)
            {
                List<string> erros = new List<string>();
                foreach (var failure in validacao.Errors)
                {
                    erros.Add("Property " + failure.PropertyName +
                        " failed validation. Error Was: "
                        + failure.ErrorMessage);
                }

                return BadRequest(erros);
            }

            var db = new Contexto();
            var obj = db.Barbeiro.FirstOrDefault(f => f.IdBarbeiro == barbeiro.IdBarbeiro);

            if (obj == null)
            {
                db.Barbeiro.Add(barbeiro);
            }
            else
            {
                obj.Nome = barbeiro.Nome;
                obj.cpf = barbeiro.cpf;
                obj.PrecoCorte = barbeiro.PrecoCorte;
                obj.Telefone = barbeiro.Telefone;
                obj.IdEspecialidade = barbeiro.IdEspecialidade;
                db.Barbeiro.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int IdBarbeiro)
        {
            var db = new Contexto();
            var barbeiro = db.Barbeiro.First(item => item.IdBarbeiro == IdBarbeiro);
            return View("Adicionar", barbeiro);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM barbeiro
            var listaDeBarbeiros = new Contexto()
                .Barbeiro
                .Include(f => f.EspecialidadeB)
                .ToList();

            return View(listaDeBarbeiros);
        }

        public IActionResult Excluir(int IdBarbeiro)
        {
            var db = new Contexto();
            var barbeiro = db.Barbeiro.First(f => f.IdBarbeiro == IdBarbeiro);
            db.Barbeiro.Remove(barbeiro);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
