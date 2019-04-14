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

namespace Termo.Generales.API.Clientes
{
    [Route("api/generales/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;

        public ClientesController(GeneralesContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]ClienteFiltroParamsDTO filtros)
        {
            var clientes = this._context.Clientes.AsQueryable();

            clientes = clientes.Where(x => x.NombreCliente.Contains(filtros.NombreCliente));

            var result = await PagedList<Cliente>.CreateAsync(clientes, filtros.PageNumber, filtros.PageSize);

            var clientesToReturnDTO = this._mapper.Map<IEnumerable<ClienteToReturnDTO>>(result);

            Response.AddPagination(result.CurrentPage, result.PageSize,
               result.TotalCount, result.TotalPages);

            return Ok(clientesToReturnDTO);
            
        }

        [HttpGet("{ID_Cliente}",Name = "GetCliente")]
        public async Task<IActionResult> Get(int ID_Cliente)
        {
            var cliente = await this._context.Clientes.FirstOrDefaultAsync(x => x.ID_Cliente == ID_Cliente);

            var clienteToReturn = this._mapper.Map<ClienteToReturnDTO>(cliente);

            return Ok(clienteToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ClienteForCreationDTO clienteForCreationDTO)
        {
            var cliente = this._mapper.Map<Cliente>(clienteForCreationDTO);

            await this._context.Clientes.AddAsync(cliente);

            var result = await this._context.SaveChangesAsync() > 0;

            var clienteToReturnDTO = this._mapper.Map<ClienteToReturnDTO>(cliente);

            if (result)
                return CreatedAtRoute("GetCliente", new { cliente.ID_Cliente }, clienteToReturnDTO);

            throw new Exception("No se pudo registrar el cliente");

        }
    }
}
