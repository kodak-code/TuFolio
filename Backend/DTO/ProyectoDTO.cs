using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProyectoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? DescripcionCorta { get; set; }

        public string? DescripcionLarga { get; set; }

        public string? UrlRepo { get; set; }

        public string? UrlDemo { get; set; }

        public string? UrlLive { get; set; }

        public int Orden { get; set; }

        public int PortfolioId { get; set; }

        public string? PortfolioSlug { get; set; }
    }
}
