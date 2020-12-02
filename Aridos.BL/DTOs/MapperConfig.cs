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

                cfg.CreateMap<Faena, FaenaDTO>().ReverseMap();

                cfg.CreateMap<Sensor, SensorDTO>().ReverseMap();

                cfg.CreateMap<DatosAceleracion, DatosAceleracionDTO>().ReverseMap();

                cfg.CreateMap<DatosTemperatura, DatosTemperaturaDTO>().ReverseMap();

                cfg.CreateMap<DatosConfiguracionAceleraciones, DatosConfiguracionAceleracionesDTO>().ReverseMap();

                cfg.CreateMap<DatosActualizacionEstados, DatosActualizacionEstadosDTO>().ReverseMap();

            });
        }
    }
}
