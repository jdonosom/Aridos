namespace Aridos.BL.DTOs
{
    using AutoMapper;
    using Aridos.BL.DTOs;
    using Aridos.BL.Models;

    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EstadoAceleracion, EstadoAceleracionDTO>().ReverseMap(); // GET
                //cfg.CreateMap<EstadoAceleracionDTO, EstadoAceleracion>(); // POST-PUT

                cfg.CreateMap<Faena, FaenaDTO>().ReverseMap();
                //cfg.CreateMap<FaenaDTO, Faena>();

                cfg.CreateMap<Sensor, SensorDTO>().ReverseMap();
                //cfg.CreateMap<SensorDTO, Sensor>();

                cfg.CreateMap<DatosAceleracion, DatosAceleracionDTO>().ReverseMap();
                //cfg.CreateMap<EstadoAceleracionDTO, EstadoAceleracion>();

            });
        }
    }
}
