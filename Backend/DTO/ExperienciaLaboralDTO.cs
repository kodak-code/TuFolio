using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExperienciaLaboralDTO
    {
        public int Id { get; set; }

        public string? Empresa { get; set; }

        public string? Puesto { get; set; }

        public DateOnly? FechaInicio { get; set; }

        public DateOnly? FechaFin { get; set; }

        public string? Seniority { get; set; }

        public string? Descripcion { get; set; }

        public int PerfilId { get; set; }

        public string? PerfilNombre { get; set; }
    }
}