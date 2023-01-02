using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface INumeroVillaService
    {
        Task<T> ObtenerTodos<T>();
        Task<T> Obtener<T>(int id);
        Task<T> Crear<T>(NumeroVillaCreateDto dto);
        Task<T> Actualizar<T>(NumeroVillaUpdateDto dto);
        Task<T> Remover<T>(int id); 
    }
}
