namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;

    public class DatosActualizacionEstadosRepository : GenericRepository<DatosActualizacionEstados>, IDatosActualizacionEstadosRepository
    {
        public DatosActualizacionEstadosRepository(AridosContext aridosContext)
            : base(aridosContext)
        {

        }
    }
}
