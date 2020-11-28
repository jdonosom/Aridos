using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Aridos.BL.Models;

namespace Aridos.BL.Data
{
    public class AridosContext : DbContext
    {
        private static AridosContext aridosContext = null;

        public AridosContext()
            : base("AridosConextionStringDES")
        {
        }

        public DbSet<EstadoAceleracion> EstadoAceleracions { get; set; }
        public DbSet<Faena> Faenas { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<DatosAceleracion> DatosAceleracions { get; set; }
        public DbSet<DatosTemperatura> DatosTemperaturas { get; set; }

        public static AridosContext Create()
        {
            //if (aridosContext == null)
            //    aridosContext = new AridosContext();

            return new AridosContext();
        }

    }
}
