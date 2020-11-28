

namespace Aridos.BL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum Razon
    {
        Pedida     = 1,
        Programada = 2,
        Alarma     = 3
    }

    [Table("EstadoAceleracion", Schema = "dbo")]
    public class EstadoAceleracion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string NumeroSerie  { get; set; }
        public int TipoSensor { get; set; }
        public DateTime Fecha { get; set; }
        public int Razon { get; set; }
        public double Bateria { get; set; }
        public double Temperatura { get; set; }
        public double Rms1 { get; set; }
        public double Rms2 { get; set; }
        public double Rms3 { get; set; }
        public int Version { get; set; }

    }
}
