namespace Aridos.BL.DTOs
{
    using Aridos.BL.Models;
    using System;

    public class DatosTemperaturaDTO
    {
        public int ID { get; set; }
        public int TipoSensor { get; set; }
        public uint NumeroSerie { get; set; }
        public double Temperatura { get; set; }
        public double TAmbiente { get; set; }
        public double TInterna { get; set; }
        public double Bateria { get; set; }
        public DateTime Fecha { get; set; }
    }
}
