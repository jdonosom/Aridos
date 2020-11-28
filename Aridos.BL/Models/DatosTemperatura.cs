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
        public double Temperatura { get; set; }
        public double TAmbiente { get; set; }
        public double TInterna { get; set; }
        public double Bateria { get; set; }
        public DateTime Fecha { get; set; }
    }
}
