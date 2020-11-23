namespace Aridos.BL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DatosAceleracion", Schema = "dbo")]
    public class DatosAceleracion
    {
        [Key]
        public int ID { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoSensor { get; set; }
        public int FrecuenciaMuestreo { get; set; }
        public double Calibracion { get; set; }
        public double ValorCanal1 { get; set; }
        public double ValorCanal2 { get; set; }
        public double ValorCanal3 { get; set; }
        public int Razon { get; set; }
    }
}
