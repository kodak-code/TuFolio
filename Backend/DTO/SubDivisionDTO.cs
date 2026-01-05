using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubDivisionDTO
    {
        public int Id { get; set; }

        public string? Codigo { get; set; }

        public string Nombre { get; set; } = null!;

        public int PaisId { get; set; }

        public string? PaisNombre { get; set; } = null!;
    }
}
