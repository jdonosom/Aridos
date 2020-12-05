namespace Aridos.BL.DTOs
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class DatosActualizacionEstadosDTO
    {
        public uint NumeroSerie { get; set; }
        public float Bateria { get; set; }
        public float Temperatura { get; set; }
    }
}
