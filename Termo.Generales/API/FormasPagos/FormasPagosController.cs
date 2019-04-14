using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termo.Generales.API.DTOs;
using Termo.Generales.API.FormasPagos;
using Termo.Generales.API.Helpers;
using Termo.Generales.Core;
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
        public async Task<IActionResult> Get([FromQuery]FormaPagoFiltroParamsDTO filtros)
        {
            var formasPagos = this._context.FormasPagos.AsQueryable();

            formasPagos = formasPagos.Where(x => x.NombreFormaPago.Contains(filtros.NombreFormaPago));            

            var result = await PagedList<FormaPago>.CreateAsync(formasPagos, filtros.PageNumber, filtros.PageSize);

            var formasPagosToReturn = _mapper.Map<IEnumerable<FormaPagoToReturnDTO>>(result);

            Response.AddPagination(result.CurrentPage, result.PageSize,
                result.TotalCount, result.TotalPages);

            return Ok(formasPagosToReturn);
        }

        [HttpGet("{ID_FormaPago}", Name ="GetFormaPago")]
        public async Task<IActionResult> Get(int ID_FormaPago)
        {
            var formaPago = await this._context.FormasPagos.FirstOrDefaultAsync(x => x.ID_FormaPago == ID_FormaPago);

            var formaPagoToReturn = _mapper.Map<FormaPagoToReturnDTO>(formaPago);

            return Ok(formaPagoToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]FormaPagoForCreationDTO formaPagoCreationDTO)
        {
            var formaPago = _mapper.Map<FormaPago>(formaPagoCreationDTO);

            await this._context.FormasPagos.AddAsync(formaPago);

            var formaPagoToReturn = _mapper.Map<FormaPagoToReturnDTO>(formaPago);

            var result = await this._context.SaveChangesAsync() > 0;

            if (result)
                return CreatedAtRoute("GetFormaPago", new { formaPago.ID_FormaPago }, formaPagoToReturn);

            throw new Exception("No fue posible guardar la forma de pago");

        }
    }
}
