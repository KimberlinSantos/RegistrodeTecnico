using System.ComponentModel.DataAnnotations;

namespace RegistrodeTecnico.Components.Models
{
    public class TipoTecnico
    {
        public int TipoId { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(50, ErrorMessage = "La descripción no puede superar los 50 caracteres")]
        public string Descripcion { get; set; }
    }

}
