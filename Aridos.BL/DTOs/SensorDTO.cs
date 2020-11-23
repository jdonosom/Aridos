namespace Aridos.BL.DTOs
{
    using Aridos.BL.Models;
    using System.ComponentModel.DataAnnotations;

    public class SensorDTO
    {
        [Required]
        public int IDSensor { get; set; }
        public string NumeroSerie { get; set; }
        [StringLength(150)]
        public string Descripcion { get; set; }
        public TipoSensor TipoSensor { get; set; }
    }
}
