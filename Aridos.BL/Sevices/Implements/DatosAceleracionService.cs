namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;

    public class DatosAceleracionService : GenericService<DatosAceleracion>
    {
        public DatosAceleracionService( IDatosAceleracionRepository datosAceleracionRepository) 
            : base(datosAceleracionRepository)
        {
        }
    }
}

