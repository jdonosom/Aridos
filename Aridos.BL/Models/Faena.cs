namespace Aridos.BL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Faena", Schema = "dbo")]
    public class Faena
    {
        [Key]
        public int IDFaena { get; set; }
        public string Descripcion { get; set; }
        public string  Ubicacion { get; set; }
    }
}
