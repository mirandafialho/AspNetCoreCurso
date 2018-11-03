using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categorias = _context.Categorias.ToList();
            return View(categorias);
        }

        [HttpGet]
        public IActionResult Salvar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(Categoria categoria)
        {
            if (categoria.Id == 0) 
            {
                _context.Categorias.Add(categoria);
            } 
            else
            {
                var EditarCategoria = _context.Categorias.First(c => c.Id == categoria.Id);
                EditarCategoria.Nome = categoria.Nome;                
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var categoria = _context.Categorias.First(c => c.Id == id);
            return View("Salvar", categoria);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var categoria = _context.Categorias.First(c => c.Id == id);
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}