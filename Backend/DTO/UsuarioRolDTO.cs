using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioRolDTO
    {
        public int Id { get; set; }

        public int RolId { get; set; }

        public string? RolNombre { get; set; }

        public int UsuarioId { get; set; }

        public string? UsuarioNombre { get; set; }

    }
}
