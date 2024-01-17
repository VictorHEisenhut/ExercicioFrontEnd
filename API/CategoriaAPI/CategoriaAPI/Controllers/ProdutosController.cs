using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CategoriaAPI.Data;
using CategoriaAPI.Entities.Dtos;
using AutoMapper;

namespace CategoriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly CategoriaContext _context;
        private readonly IMapper _mapper;

        public ProdutosController(CategoriaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var prods = await _context.Produtos.ToListAsync();
            foreach (var produto in prods)
            {
                produto.Categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == produto.CategoriaId);
            }
            return prods;
        }

        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            produto.Categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == produto.CategoriaId);


            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }
        
        [HttpGet("categoria/{categoriaId}")]
        
        public async Task<ActionResult<List<Produto>>> GetProdutosByCategoria(int categoriaId)
        {
            List<Produto> prods = new();
            var produtos = await _context.Produtos.ToListAsync();
            foreach (var produto in produtos)
            {
                if (produto.CategoriaId == categoriaId)
                {

                    prods.Add(produto);
                }
                produto.Categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == produto.CategoriaId);
            }   


            if (produtos == null)
            {
                return NotFound();
            }

            return prods;
        }

        // PUT: api/Produtos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, UpdateProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            produto.Id = id;
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Produtos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(CreateProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            produto.Categoria = _context.Categorias.FirstOrDefault(c => c.Id == produtoDto.CategoriaId);
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
