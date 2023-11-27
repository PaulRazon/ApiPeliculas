using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Models.Dto
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [MaxLength(60,ErrorMessage = "El numero maximo de caracteres es de 100!")]
        public string Nombre { get; set; }
    }
}
