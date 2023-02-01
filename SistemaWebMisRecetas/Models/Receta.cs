using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebMisRecetas.Validations;
using System.ComponentModel;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(10)")]
        [StringLength(10)]
        [Categoria]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(200)")]
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(500)")]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(20)")]
        [StringLength(20)]
		[Display(Name = "Autor")]

		public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(20)")]
        [StringLength(20)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [CheckAge]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(100)")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        public string Email { get; set; }
    }
}
