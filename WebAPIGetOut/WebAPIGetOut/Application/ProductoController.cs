using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPIGetOut.Data;
using WebAPIGetOut.Domain;
using WebAPIGetOut.Domain.DTOs;
using WebAPIGetOut.Persistence.Interfaces;

namespace WebAPIGetOut.Application
{
    [ApiController]
    [Route("api/productos")]
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _getOutDb;
        private readonly ILogger<ProductoController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public ProductoController(ApplicationDbContext getOutDb , ILogger<ProductoController> logger, IMapper mapper, IUnitOfWork uow)
        {
            _getOutDb = getOutDb;
            _logger = logger;
            _mapper = mapper;
            _uow = uow;
        }

        [HttpGet("productos")]
        public async Task<ActionResult> GetAll()
        {
            var productos = await _uow.Producto.GetAll();
            var productosDTO = _mapper.Map<List<ProductoDTO>>(productos);

            return Ok(productosDTO);
        }

        [HttpGet("producto/{id:int}")]
        public async Task<ActionResult> GetById(int id)
        {
            var producto = await _uow.Producto.GetById(id);
            var productoDTO = _mapper.Map<ProductoDTO>(producto);

            return Ok(productoDTO);
        }

        [HttpPost("producto")]
        public async Task<ActionResult> Create(Producto producto)
        {
            //Busco por el mismo nombre , y condiciono
            var existeMismoNombre = await _getOutDb.Productos.AnyAsync(x => x.Nombre == producto.Nombre);
            if (existeMismoNombre)
            {
                return BadRequest($"Ya existe un producto con nombre{producto.Nombre}");
            }
                
             _uow.Producto.Add(producto);
             
              var resultado = await _uow.Complete();
              return Ok(resultado);
        }

        [HttpPut("producto/{id}")]
        public async Task<ActionResult> Update(Producto producto, int id)
        {
            var productoEncontrado = await _getOutDb.Productos.FindAsync(id);
            if (productoEncontrado == null)
            {
                return NotFound("No se encontró el registro a actualizar");
            }

            _uow.Producto.Update(producto);
            var resultado = await _uow.Complete();
            return Ok(resultado);
        }

        [HttpDelete("producto/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var productoEncontrado = await _uow.Producto.GetById(id);
            if(productoEncontrado == null)
            {
                return NotFound("No se encontro el registro a eliminar");
            }

            _uow.Producto.Delete(productoEncontrado);
            var resultado = await _uow.Complete();
            return Ok(new { id });
        }
    }
}
