namespace Aridos.BL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DatosActualizacionEstados", Schema = "dbo")]
    public class DatosActualizacionEstados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroSerie { get; set; }
        public double Bateria { get; set; }
        public double Temperatura { get; set; }
    }
}
