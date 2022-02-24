﻿using AutoMapper;
using StudyProject.Domain;

namespace StudyProject.Infrastructure.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Customer, Entidades.Customer>().ReverseMap();
            CreateMap<Endereco, Entidades.Endereco>().ReverseMap();
        }
    }
}
