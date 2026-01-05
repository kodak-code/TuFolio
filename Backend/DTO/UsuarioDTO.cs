using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Apellido { get; set; }

        public string Gmail { get; set; } = null!;

        public string FechaCreacion { get; set; }

        public int Activo { get; set; }

        public int Verificado { get; set; }

        public int? SubDivision { get; set; }

        public string? SubDivisionNombre { get; set; }
    }
}
