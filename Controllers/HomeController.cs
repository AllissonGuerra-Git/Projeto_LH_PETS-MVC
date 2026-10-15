using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using System.Collections.Generic;

namespace LHPet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(new Cliente(1, "Carlos Silva", "111.222.333-44", "carlos@email.com", "Mel (Cachorro)"));
            listaClientes.Add(new Cliente(2, "Ana Souza", "222.333.444-55", "ana@email.com", "Bolt (Gato)"));
            ViewBag.listaClientes = listaClientes;

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(new Fornecedor(1, "VetDistribuidora Ltda", "00.111.222/0001-33", "contato@vetdist.com"));
            listaFornecedores.Add(new Fornecedor(2, "PetShop Atacado", "44.555.666/0001-77", "vendas@petracoes.com"));
            ViewBag.listaFornecedores = listaFornecedores;

            return View();
        }
    }
}