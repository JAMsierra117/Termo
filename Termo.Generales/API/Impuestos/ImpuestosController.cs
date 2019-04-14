using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termo.Generales.API.Helpers;
using Termo.Generales.Core;
using Termo.Generales.Data;

namespace Termo.Generales.API.Impuestos
{
    [Route("api/generales/[controller]")]
    [ApiController]
    public class ImpuestosController : Controller
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;

        public ImpuestosController(GeneralesContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet] 
        public async Task<IActionResult> Get([FromQuery]ImpuestoFiltroParamsDTO filtros)
        {
            var impuestos = this._context.Impuestos.AsQueryable();

            var result = await PagedList<Impuesto>.CreateAsync(impuestos, filtros.PageNumber, filtros.PageSize);

            var impuestosToReturn = this._mapper.Map<IEnumerable<ImpuestoToReturnoDTO>>(result);

            Response.AddPagination(result.CurrentPage, result.PageSize, result.TotalCount, result.TotalPages);

            return Ok(impuestosToReturn);
        }

        [HttpGet("{ID_Impuesto}", Name ="GetImpuesto")]
        public async Task<IActionResult> Get(int ID_Impuesto)
        {
            var impuesto = await this._context.Impuestos.FirstOrDefaultAsync(x => x.ID_Impuesto == ID_Impuesto);

            var impuestoToReturnDTO = this._mapper.Map<ImpuestoToReturnoDTO>(impuesto);

            return Ok(impuestoToReturnDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ImpuestoForCreationDTO impuestoForCreationDTO)
        {
            var impuesto = this._mapper.Map<Impuesto>(impuestoForCreationDTO);


            await this._context.Impuestos.AddAsync(impuesto);


            var result = await this._context.SaveChangesAsync() > 0;

            var impuestoToReturnDTO = this._mapper.Map<ImpuestoToReturnoDTO>(impuesto);

            if (result)
                return CreatedAtRoute("GetImpuesto", new { impuesto.ID_Impuesto }, impuestoToReturnDTO);


            throw new Exception("No se pudo generar el impuesto");

        }
    }
}
