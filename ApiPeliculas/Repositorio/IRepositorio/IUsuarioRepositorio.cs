using ApiPeliculas.Modelos;
using ApiPeliculas.Models;
using ApiPeliculas.Models.Dto;

namespace ApiPeliculas.Repositorio.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        ICollection<Usuario> GetUsuarios();
        Usuario GetUsuario(int usuarioId);
        bool IsUniqueUser(string usuario);

        Task<UsuarioLoginRespuestaDto> Login(UsuarioLoginDto usuarioLoginDto);

        Task<Usuario> Registro(UsuarioRegistroDto usuarioLoginDto);

    }
}
