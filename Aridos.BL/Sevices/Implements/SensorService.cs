namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;

    public class SensorService : GenericService<Sensor>
    {
        public SensorService(ISensorRepository sensorRepository) : base(sensorRepository)
        {
        }
    }
}
