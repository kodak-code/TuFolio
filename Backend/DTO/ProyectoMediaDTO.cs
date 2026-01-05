using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProyectoMediaDTO
    {
        public int Id { get; set; }

        public int ProyectoId { get; set; }

        public string? ProyectoNombre { get; set; }

        public int MediaId { get; set; }

        public string? MediaAltText { get; set; }

        public string? Proposito { get; set; }
    }
}
