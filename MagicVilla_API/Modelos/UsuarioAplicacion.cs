using Microsoft.AspNetCore.Identity;

namespace MagicVilla_API.Modelos
{
    public class UsuarioAplicacion :IdentityUser
    {

        public string Nombres { get; set; }

    }
}
