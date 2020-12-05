namespace Aridos.BL.DTOs
{
    using Aridos.BL.Models;
    using System;

    public class DatosTemperaturaDTO
    {
        public int ID { get; set; }
        public int TipoSensor { get; set; }
        public uint NumeroSerie { get; set; }
        public float Temperatura { get; set; }
        public float TAmbiente { get; set; }
        public float TInterna { get; set; }
        public float Bateria { get; set; }
        public DateTime Fecha { get; set; }
    }
}
