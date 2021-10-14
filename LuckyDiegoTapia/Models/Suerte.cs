using System.ComponentModel.DataAnnotations;

namespace LuckyDiegoTapia.Models
{
    public enum DetalleType
    {
        Malasuerte = 0,
        Buenasuerte = 1,
    }
    public class Person
    {
        [Key]
        public int SuerteId { get; set; }
        [StringLength(10, MinimumLength = 1, ErrorMessage = "contiene del 1 al 10")]
        
        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Quien consulta su suerte?")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Detalle buena o mala suerte que le llegará")]
        public DetalleType Detalle { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }

    }
}
