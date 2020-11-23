namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;

    public class EstadoAceleracionRepository: GenericRepository<EstadoAceleracion>, IEstadoAceleracionRepository
    {
        public EstadoAceleracionRepository(AridosContext aridosContext) : base(aridosContext)
        {
        }
    } 
}
