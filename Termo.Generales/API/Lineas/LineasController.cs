using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termo.Generales.API.DTOs;
using Termo.Generales.API.Helpers;
using Termo.Generales.API.Lineas;
using Termo.Generales.Core;
using Termo.Generales.Data;

namespace Termo.Generales.API.Controllers
{
    [Route("api/Generales/[controller]")]
    [ApiController]
    public class LineasController : Controller
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;

        public LineasController(GeneralesContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]LineaFiltroParamsDTO filtros)
        {
            var lineas = this._context.Lineas.AsQueryable();

            var result = await PagedList<Linea>.CreateAsync(lineas, filtros.PageNumber, filtros.PageSize);

            var lineasToReturn = _mapper.Map<IEnumerable<LineasToReturnDTO>>(result);

            Response.AddPagination(result.CurrentPage, result.PageSize, result.TotalCount, result.TotalPages);

            return Ok(lineasToReturn);

        }

        [HttpGet("{ID_Linea}", Name = "GetLinea")]
        public async Task<IActionResult> Get(int ID_Linea)
        {
            var linea = await this._context.Lineas.FirstOrDefaultAsync(x => x.ID_Linea == ID_Linea);

            var lineaToReturn = _mapper.Map<LineasToReturnDTO>(linea);

            return Ok(lineaToReturn);

        }

        [HttpPost]
        public async Task<IActionResult> Post(LineaForCreationDTO lineaForCreationDTO)
        {
            var linea = _mapper.Map<Linea>(lineaForCreationDTO);

            await this._context.Lineas.AddAsync(linea);

            var lineaToReturn = _mapper.Map<LineasToReturnDTO>(linea);

            var result = await this._context.SaveChangesAsync() > 0;

            if (result)
                return CreatedAtRoute("GetLinea", new { ID_Linea = linea.ID_Linea }, lineaToReturn);

            throw new Exception("No fue posible guardar la linea");

        }

        [HttpDelete("{ID_Linea}")]
        public async Task<IActionResult> Delete(int ID_Linea)
        {
            var linea = await this._context.Lineas.FirstOrDefaultAsync(x => x.ID_Linea == ID_Linea);


            if (linea == null)
                return BadRequest("No existe la linea a eliminar");


            this._context.Lineas.Remove(linea);

            var result = await this._context.SaveChangesAsync() > 0;

            if (result)
                return Ok();

            throw new Exception("No se pudo eliminar la linea");

        }
    }
}
