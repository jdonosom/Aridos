namespace Aridos.BL.DTOs
{
    using Aridos.BL.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EstadoAceleracionDTO
    {
        [Required(ErrorMessage = "El campo NumeroSerie es requerido")]
        public string NumeroSerie { get; set; }
        public int TipoSensor { get; set; }
        public DateTime Fecha { get; set; }
        public Razon Razon { get; set; }
        public double Bateria { get; set; }
        public double Temperatura { get; set; }
        public double Rms1 { get; set; }
        public double Rms2 { get; set; }
        public double Rms3 { get; set; }
        public int Version { get; set; }
    }
}
