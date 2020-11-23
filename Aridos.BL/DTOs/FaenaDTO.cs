namespace Aridos.BL.DTOs
{
    using System.ComponentModel.DataAnnotations;
    public class FaenaDTO
    {
        [Required]
        public int IDFaena { get; set; }
        [StringLength(150)]
        public string Descripcion { get; set; }
        [StringLength(150)]
        public string Ubicacion { get; set; }
    }
}
