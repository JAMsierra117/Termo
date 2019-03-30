using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Termo.Generales.Data;
using Termo.Generales.API.DTOs;
using AutoMapper;

namespace Termo.Generales.API.Controllers
{
    [Route("api/Generales/[controller]")]
    public class ProductosController : Controller
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;

        public ProductosController(GeneralesContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datos = await this._context.Productos.Include(p => p.Linea).ToListAsync();

            var productos = _mapper.Map<IEnumerable<ProductoToReturnDTO>>(datos);

            return Ok(productos);
        }
    }
}

