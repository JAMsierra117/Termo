using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Termo.Generales.API.Clientes;
using Termo.Generales.API.DTOs;
using Termo.Generales.API.Impuestos;
using Termo.Generales.API.ZonasImpuestos;
using Termo.Generales.Core;

namespace Termo.Generales.API.Helpers
{
    public class AuthoMapperProfiles : Profile
    {
        public AuthoMapperProfiles()
        {
            CreateMap<Producto, ProductoToReturnDTO>()
            .ForMember(dest => dest.Linea, opt => {
                opt.MapFrom(src => src.Linea.NombreLinea);

            });

            CreateMap<Linea, LineaToReturnDTO>();
            CreateMap<LineaForCreationDTO, Linea>();

            CreateMap<FormaPago, FormaPagoToReturnDTO>();
            CreateMap<FormaPagoForCreationDTO, FormaPago>();

            CreateMap<Cliente, ClienteToReturnDTO>();
            CreateMap<ClienteForCreationDTO, Cliente>();

            CreateMap<Impuesto, ImpuestoToReturnoDTO>();
            CreateMap<ImpuestoForCreationDTO, Impuesto>();

            CreateMap<ZonaImpuesto, ZonaImpuestoToReturnDTO>();
            CreateMap<ZonaImpuestoForCreationDTO, ZonaImpuesto>();



            //CreateMap<ProductoForCreationDTO, Producto>().ReverseMap();


        }

    }
}