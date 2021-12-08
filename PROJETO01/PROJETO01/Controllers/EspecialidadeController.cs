using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class EspecialidadeController : Controller
    {
        public IActionResult Index(int idEpec, string especialidade)
        {
            var objeto = new EspecialidadeB();
            objeto.IdEspecialidade = idEpec;
            objeto.Especialidade = especialidade;

            return View(objeto);
           
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarConfirmacao(EspecialidadeB ent)
        {
            var db = new Contexto();
            var obj = db.EspecialidadeB.FirstOrDefault(f => f.IdEspecialidade == ent.IdEspecialidade);

            if (obj == null)
            {
                db.EspecialidadeB.Add(ent);
            }
            else
            {
                obj.Especialidade = ent.Especialidade;
                db.EspecialidadeB.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int IdEspecialidade)
        {
            var db = new Contexto();
            var especialidade = db.EspecialidadeB.First(item => item.IdEspecialidade == IdEspecialidade);
            return View("Adicionar", especialidade);
        }
        public IActionResult Listar()
        {

            //SELECT * FROM especialidade
            var listaDeEspecialidade = new Contexto().EspecialidadeB.ToList();

            return View(listaDeEspecialidade);
        }

        public IActionResult Excluir(int IdEspecialidade)
        {
            var db = new Contexto();
            var especialidade = db.EspecialidadeB.First(f => f.IdEspecialidade == IdEspecialidade);
            db.EspecialidadeB.Remove(especialidade);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
