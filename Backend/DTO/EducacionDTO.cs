using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EducacionDTO
    {
        public int Id { get; set; }

        public string? Institucion { get; set; }

        public string? Titulo { get; set; }

        public DateOnly? FechaInicio { get; set; }

        public DateOnly? FechaFin { get; set; }

        public int PerfilId { get; set; }

        public string? PerfilNombre { get; set; }
    }
}
