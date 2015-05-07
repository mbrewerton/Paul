using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace DAL.Mapping
{
    public static class AutoMapperServicesConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
                {
                    // Entity to Dto
                    cfg.AddProfile(new FilmDtoProfile());
                });
        }
    }
}
