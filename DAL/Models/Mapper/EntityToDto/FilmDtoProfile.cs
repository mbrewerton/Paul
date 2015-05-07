﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;
using DAL.Models.Dto;

namespace DAL.Mapping
{
    public class FilmDtoProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Film, FilmDto>();
        }
    }
}