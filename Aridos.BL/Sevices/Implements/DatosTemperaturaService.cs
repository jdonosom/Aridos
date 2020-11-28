namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;

    public class DatosTemperaturaService : GenericService<DatosTemperatura>
    {
        public DatosTemperaturaService( IDatosTemperaturaRepository datosTemperaturaRepository)
            : base(datosTemperaturaRepository)
        {
        }
    }
}
