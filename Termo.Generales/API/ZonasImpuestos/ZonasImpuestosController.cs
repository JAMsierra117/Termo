using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Termo.Generales.Core;
using Termo.Generales.Data;

namespace Termo.Generales.API.ZonasImpuestos
{
    [Route("api/generales/[controller]")]
    [ApiController]
    public class ZonasImpuestosController : Controller
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;

        public ZonasImpuestosController(GeneralesContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var zonas = await this._context.ZonasImpuestos.ToListAsync();

            var zonasImpuestosToReturnDTO = this._mapper.Map<IEnumerable<ZonaImpuestoToReturnDTO>>(zonas);

            return Ok(zonasImpuestosToReturnDTO);
        }

        [HttpGet("{ID_ZonaImpuesto}", Name = "GetZonaImpuesto")]
        public async Task<IActionResult> Get(int ID_ZonaImpuesto)
        {
            var zona = await this._context.ZonasImpuestos.FirstOrDefaultAsync(x => x.ID_ZonaImpuesto == ID_ZonaImpuesto);

            var zonaImpuestoToReturnDTO = this._mapper.Map<ZonaImpuestoToReturnDTO>(zona);

            return Ok(zonaImpuestoToReturnDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ZonaImpuestoForCreationDTO zonaImpuestoForCraetionDTO)
        {
            var zona = this._mapper.Map<ZonaImpuesto>(zonaImpuestoForCraetionDTO);


            await this._context.ZonasImpuestos.AddAsync(zona);


            var result = await this._context.SaveChangesAsync() > 0;

            var zonaImpuestoToReturnDTO = this._mapper.Map<ZonaImpuestoToReturnDTO>(zona);

            if (result)
                return CreatedAtRoute("GetZonaImpuesto", new { zona.ID_ZonaImpuesto }, zonaImpuestoToReturnDTO);

            throw new Exception("No se pudo generar la zona de impuesto");
        }
    }
}
