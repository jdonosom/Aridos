namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;

    public class EstadoAceleracionService : GenericService<EstadoAceleracion>, IEstadoAceleracionService
    {
        public EstadoAceleracionService(IEstadoAceleracionRepository estadoAceleracionRepository) : base(estadoAceleracionRepository)
        { 
        }
    }
}
