using ServiceClient;

namespace ServiceWebApp.ViewModels
{
    public class ViewUsuarioDto
    {
        public Usuario Usuario { get; set; } = new();
        public List<UsuarioDto> Usuarios { get; set; } = new();
        public int Id { get; set; }
    }
}
