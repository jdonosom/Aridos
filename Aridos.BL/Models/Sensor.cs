namespace Aridos.BL.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum TipoSensor
    {
        SensorInfrarojo = 1,
        SensorTermocopla = 2,
        SensorVibracion = 3
    }

    [Table("Sensor", Schema = "dbo")]
    public class Sensor
    {
        [Key]
        public int IDSensor { get; set; }
        public string NumeroSerie { get; set; }
        public string Descripcion { get; set; }
        public TipoSensor TipoSensor { get; set; }
    }
}
