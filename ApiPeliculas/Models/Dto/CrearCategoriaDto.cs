using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Models.Dto
{
    public class CrearCategoriaDto
    {
        //Esta validacion es importante si no creara un nombre vacio
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(60, ErrorMessage = "El numero maximo de caracteres es de 100!")]
        public string Nombre { get; set; }
    }
}
