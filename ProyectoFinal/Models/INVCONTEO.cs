using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class INVCONTEO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DESCRIPCION { get; set; } = null!;
        [Required]
        public int CANTIDAD { get; set; }
    }
}
