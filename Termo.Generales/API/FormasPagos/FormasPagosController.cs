using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Termo.Generales.API.DTOs;
using Termo.Generales.Data;

namespace Termo.Generales.API.Controllers
{
    [Route("api/Generales/[controller]")]
    [ApiController]
    public class FormasPagosController : Controller
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;

        public FormasPagosController(GeneralesContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var formasPagos = await this._context.FormasPagos.ToListAsync();

            var formasPagosToReturn = _mapper.Map<IEnumerable<FormaPagoToReturnDTO>>(formasPagos);

            return Ok(formasPagosToReturn);
        }

        [HttpGet("{ID_FormaPago}")]
        public async Task<IActionResult> Get(int ID_FormaPago)
        {
            var formaPago = await this._context.FormasPagos.FirstOrDefaultAsync(x => x.ID_FormaPago == ID_FormaPago);

            var formaPagoToReturn = _mapper.Map<FormaPagoToReturnDTO>(formaPago);

            return Ok(formaPagoToReturn);
        }
    }
}
