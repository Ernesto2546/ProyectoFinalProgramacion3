using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalProgramacion3.Models
{
    public class INVCONTEO
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string DESCRIPCION { get; set; } = null!;
        [Required]
        public int CANTIDAD { get; set; }
    }
}
