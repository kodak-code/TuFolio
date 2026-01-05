using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AuthDTO
    {
        public int Id { get; set; }

        public string? Proveedor { get; set; }

        public string? ProveedorUsuarioId { get; set; }

        public byte[]? PasswordHash { get; set; }

        public int IntentosFallidos { get; set; }

        public string? BloqueoHasta { get; set; }

        public int UsuarioId { get; set; }

        public string? UsuarioNombre{ get; set; }
    }
}