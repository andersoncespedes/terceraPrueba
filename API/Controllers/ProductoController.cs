using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;
using Core.Entities;
using Infrastructure.Repository;
using infrastructure.Data;

namespace API.Controllers;

    public class ProductoController : BaseApiController
    {
        private readonly BodegaContext _context;
        public ProductoController(BodegaContext context){
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Producto>>> Get(){
            var res = await _context.Productos.ToListAsync();
            return Ok(res);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Producto>> get(int id){
           var res = await _context.Productos.FindAsync(id);
           return Ok(res);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async void Post(){
            var res =  _context.Productos.Add(new Producto {NombreProducto = "anderson", CodeProducto = "kasd342", Precio = 23.123, Cantidad = 1234});
            await _context.SaveChangesAsync();
        }
}
