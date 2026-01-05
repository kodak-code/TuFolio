using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TecnologiaDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Categoria { get; set; }

        public string? Slug { get; set; }

        public string? IconoUrl { get; set; }
    }
}
