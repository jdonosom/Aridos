namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;
    using System;

    public class DatosAceleracionRepository : GenericRepository<DatosAceleracion>, IDatosAceleracionRepository
    {
        public DatosAceleracionRepository(AridosContext aridosContext) : base(aridosContext)
        {
        }
    }
}
