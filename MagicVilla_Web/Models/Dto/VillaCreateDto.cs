

using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaCreateDto
    {

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public string Detalle { get; set; }

        [Required(ErrorMessage ="Tarifa es Requerido")]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }

        public string ImagenUrl { get; set; }

        public string Amenidad { get; set; }
    }
}
