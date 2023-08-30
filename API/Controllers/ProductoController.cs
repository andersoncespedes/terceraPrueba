using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;
using Core.Entities;
using Infrastructure.Repository;
using infrastructure.Data;
using Infrastructure.UnitOfWork;

namespace API.Controllers;

    public class ProductoController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductoController(IUnitOfWork unitOfWork){
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Producto>>> Get(){
            var res = await _unitOfWork.Productos.GetAllAsync();
            return Ok(res);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Producto>> get(int id){
           var res = await _unitOfWork.Productos.GetByIdAsync(id);
           return Ok(res);
        }

}
