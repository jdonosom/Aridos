namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;

    public class DatosConfiguracionAceleracionesRepository : GenericRepository<DatosConfiguracionAceleraciones>, IDatosConfiguracionAceleracionesRepository
    {
        public DatosConfiguracionAceleracionesRepository(AridosContext aridosContext) 
            : base(aridosContext)
        {
        }
    }
}
