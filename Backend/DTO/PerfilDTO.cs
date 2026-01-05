using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PerfilDTO
    {
        public int Id { get; set; }

        public string? NombrePublico { get; set; }

        public string? Titulo { get; set; }

        public string? Biografia { get; set; }

        public string? AvatarUrl { get; set; }

        public bool? Pais { get; set; }

        public int UsuarioId { get; set; }

        public string? UsuarioNombre { get; set; }
    }
}
