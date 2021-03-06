using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class SolicitaCorteController : Controller
    {

        [HttpGet]
        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Cliente = db.Cliente.ToList();
            ViewBag.Barbeiro = db.Barbeiro.ToList();
            ViewBag.Cidade = db.Cidade.ToList();
            return View();
        }

        public IActionResult AdicionarConfirmacao(SolicitarCorte solicitarcorte)
        {
            var db = new Contexto();
            var obj = db.SolicitarCorte.FirstOrDefault(f => f.IdSolicitacao == solicitarcorte.IdSolicitacao);

            if (obj == null)
            {
                db.SolicitarCorte.Add(solicitarcorte);
            }
            else
            {
                obj.IdCliente = solicitarcorte.IdCliente;
                obj.IdBarbeiro = solicitarcorte.IdBarbeiro;
                obj.IdCidade = solicitarcorte.IdCidade;
                obj.PrecoCorte = solicitarcorte.PrecoCorte;
                obj.Logradouro = solicitarcorte.Logradouro;
                obj.Bairro = solicitarcorte.Bairro;
                obj.Complemento = solicitarcorte.Complemento;
                obj.Numero = solicitarcorte.Numero;

                db.SolicitarCorte.Update(obj);
            }

            db.SaveChanges();
            
            return RedirectToAction("Listar");
        }

        
        [HttpGet]
        public IActionResult Editar(int IdSolicitacao)
        {
           
          
            var db = new Contexto();
            ViewBag.Cliente = db.Cliente.ToList();
            ViewBag.Barbeiro = db.Barbeiro.ToList();
            ViewBag.Cidade = db.Cidade.ToList();
            var corte = db.SolicitarCorte.First(item => item.IdSolicitacao == IdSolicitacao);
            return View("Adicionar", corte);
        }


        public IActionResult Excluir(int IdSolicitacao)
        {
            var db = new Contexto();
            var corte = db.SolicitarCorte.First(f => f.IdSolicitacao == IdSolicitacao);
            db.SolicitarCorte.Remove(corte);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }

    }
}
