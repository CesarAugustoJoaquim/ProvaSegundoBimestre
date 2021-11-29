using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 1, Nome = "Cosmeticos" },
                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "Hidratante de toranja", Preco = 45.95, Quantidade = 300, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Baton de toranja", Preco = 25.15, Quantidade = 800, CategoriaId = 1 },
                    new Produto { ProdutoId = 3, Nome = "Sabonete de toranja", Preco = 15.90, Quantidade = 450, CategoriaId = 1 },
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}