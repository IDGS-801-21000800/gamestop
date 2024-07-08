using APIsJuegos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace APIsJuegos.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ProductosController : Controller
    {
        private readonly JuegosContext _bd;

        public ProductosController (JuegosContext bd) 
        {
            _bd = bd;
        }

        [Route("/getProductos")]
        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            var productos = await _bd.Productos.ToListAsync();
            return Ok(productos);
        }

        [Route("/getProductosCategoria")]
        [HttpGet]
        public async Task<IActionResult> GetProductosCategoria(int Categoria)
        {
            var productos = from p in _bd.Productos select p;
            productos = productos.Where(s => s.Categoria == Categoria);

            return Ok(productos);
        }
    }
}
