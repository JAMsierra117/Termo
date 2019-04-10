using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Termo.Generales.API.DTOs;
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

            CreateMap<Linea, LineasToReturnDTO>();
            CreateMap<LineaForCreationDTO, Linea>();

            CreateMap<FormaPago, FormaPagoToReturnDTO>();
            CreateMap<FormaPagoForCreationDTO, FormaPago>();

            //CreateMap<ProductoForCreationDTO, Producto>().ReverseMap();


        }

    }
}