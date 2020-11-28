namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;

    public class DatosConfiguracionAceleracionesService : GenericService<DatosConfiguracionAceleraciones>
    {
        public DatosConfiguracionAceleracionesService( IDatosConfiguracionAceleracionesRepository datosConfiguracionAceleracionesRepository  )
            : base (datosConfiguracionAceleracionesRepository)
        {
        }

    }
}
