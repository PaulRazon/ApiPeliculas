using Microsoft.AspNetCore.Identity;

namespace ApiPeliculas.Models
{
    public class AppUsuario: IdentityUser
    {
        //añadir campos personalizado
        public string Nombre { get; set; }

    }
}
