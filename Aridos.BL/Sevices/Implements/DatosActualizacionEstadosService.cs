namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;
    public class DatosActualizacionEstadosService : GenericService<DatosActualizacionEstados> 
    {
        public DatosActualizacionEstadosService(IDatosActualizacionEstadosRepository datosActualizacionEstadosService)
            : base(datosActualizacionEstadosService)
        {

        }
    }
}
