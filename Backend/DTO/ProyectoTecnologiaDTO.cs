using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProyectoTecnologiaDTO
    {
        public int Id { get; set; }

        public int ProyectoId { get; set; }

        public string? ProyectoNombre { get; set; }

        public int TecnologiaId { get; set; }

        public string? TecnologiaNombre { get; set; }

        public string? Nota { get; set; }
    }
}
