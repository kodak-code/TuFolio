using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PortfolioDTO
    {
        public int Id { get; set; }

        public string SlugPublico { get; set; } = null!;

        public string Visibilidad { get; set; } = null!;

        public DateOnly? FechaPublicacion { get; set; }

        public int PerfilId { get; set; }

        public string? PerfilNombre { get; set; }
    }
}
