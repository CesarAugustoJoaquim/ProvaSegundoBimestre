using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/formadepagemento")]
    public class FormaDePagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FormaDePagamentoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/formadepagemento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] FormasDePagamento formaDePagmento)
        {
            _context.FormasDePagamento.Add(formaDePagmento);
            _context.SaveChanges();
            return Created("", formaDePagmento);
        }

        //GET: api/formadepagemento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FormasDePagamento.ToList());
    }
}