using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aridos.BL.Models
{
    public class ConfiguracionAceleraciones
    {
        public uint NumeroSerie { get; set; }
        /// <summary>
        /// Intervalo de envio de datos
        /// </summary>
        public int IntervalSendData { get; set; }
        /// <summary>
        /// Frecuencia de muestreo
        /// </summary>
        public int SampleRate { get; set; }
        /// <summary>
        /// Muestras
        /// </summary>
        public int Samples { get; set; }
        /// <summary>
        /// Rango
        /// </summary>
        public int Range { get; set; }
        /// <summary>
        /// Alarma roja
        /// </summary>
        public float RedAlarm { get; set; }
        /// <summary>
        /// Alarma naranga
        /// </summary>
        public float OrangeAlarm { get; set; }
        /// <summary>
        /// Alarma Amarilla
        /// </summary>
        public float YellowAlarm { get; set; }
        /// <summary>
        /// Intervalo RMS
        /// </summary>
        public int IntervalRMS { get; set; }
        /// <summary>
        /// Version del sensor
        /// </summary>
        public string NodeVersion { get; set; }



    }
}
