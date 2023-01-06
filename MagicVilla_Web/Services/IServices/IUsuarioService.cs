using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IUsuarioService
    {
        Task<T> Login<T>(LoginRequestDto dto);
        Task<T> Registrar<T>(RegistroRequestDto dto);
    }
}
