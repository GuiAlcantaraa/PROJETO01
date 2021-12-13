using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class ClienteController : Controller
    {
       

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Cliente cliente)
        {
            var db = new Contexto();
            var obj = db.Cliente.FirstOrDefault(f => f.IdCliente == cliente.IdCliente);

            if (obj == null)
            {
                db.Cliente.Add(cliente);
            }
            else
            {
                obj.Nome = cliente.Nome;
                obj.Cpf = cliente.Cpf;
                obj.Sexo = cliente.Sexo;
                obj.Telefone = cliente.Telefone;
                obj.Cep = cliente.Cep;
                obj.Logradouro = cliente.Logradouro;
                obj.Complemento = cliente.Complemento;
                obj.Bairro = cliente.Bairro;
                obj.Numero = cliente.Numero;  
                obj.IdCidade = cliente.IdCidade;

                db.Cliente.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        public IActionResult Listar()
        {

            //SELECT * FROM barbeiro
            var listaDeClientes = new Contexto().Cliente.ToList();
            
            return View(listaDeClientes);
        }

        [HttpGet]
        public IActionResult Editar(int IdCliente)
        {
            var db = new Contexto();
            var cliente = db.Cliente.First(item => item.IdCliente == IdCliente);
            return View("Adicionar", cliente);

        }


        public IActionResult Excluir(int IdCliente)
        {
            var db = new Contexto();
            var cliente = db.Cliente.First(f => f.IdCliente == IdCliente);
            db.Cliente.Remove(cliente);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }

    }
}
