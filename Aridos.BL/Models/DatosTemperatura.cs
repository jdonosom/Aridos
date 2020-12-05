namespace Aridos.BL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DatosTemperatura", Schema = "dbo")]
    public class DatosTemperatura
    {
        [Key]
        public int ID { get; set; }
        public int TipoSensor { get; set; }
        public string NumeroSerie { get; set; }
        public float Temperatura { get; set; }
        public float TAmbiente { get; set; }
        public float TInterna { get; set; }
        public float Bateria { get; set; }
        public DateTime Fecha { get; set; }
    }
}
