using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var produtos = _context.Produtos.Include(p => p.Categoria).ToList();
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Salvar()
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(Produto produto)
        {
            if (produto.Id == 0) 
            {
                _context.Produtos.Add(produto);
            }
            else
            {
                var EditarProduto = _context.Produtos.First(p => p.Id == produto.Id);
                EditarProduto.Nome = produto.Nome;
                EditarProduto.CategoriaId = produto.CategoriaId;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            var produto = _context.Produtos.First(p => p.Id == id);
            return View("Salvar", produto);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var produto = _context.Produtos.First(p => p.Id == id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}