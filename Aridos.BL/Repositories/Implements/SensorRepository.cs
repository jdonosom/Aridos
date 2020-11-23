namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;
    public class SensorRepository: GenericRepository<Sensor>
    {
        public SensorRepository( AridosContext aridosContext) : base(aridosContext)
        {
        }

    }
}
