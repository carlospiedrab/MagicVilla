using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> ObtenerTodos<T>(string token);
        Task<T> Obtener<T>(int id, string token);
        Task<T> Crear<T>(VillaCreateDto dto, string token);
        Task<T> Actualizar<T>(VillaUpdateDto dto, string token);
        Task<T> Remover<T>(int id, string token); 
    }
}
