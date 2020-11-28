namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;

    public class DatosTemperaturaRepository : GenericRepository<DatosTemperatura>, IDatosTemperaturaRepository
    {
        public DatosTemperaturaRepository(AridosContext aridosContext) : base (aridosContext)
        {
        }
    }
}
