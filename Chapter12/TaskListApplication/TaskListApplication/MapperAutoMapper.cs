using Service;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskListApplication.ViewModel;

namespace TaskListApplication
{
    public class MapperAutoMapper : IObjectMapper
    {
        private AutoMapper.MapperConfiguration config;
        public MapperAutoMapper()
        {
            config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TaskDto, TaskViewModel>();
            });
        }

        public TDestination Map<TDestination>(object source)
        {
            return config.CreateMapper().Map<TDestination>(source);
        }
    }
}
