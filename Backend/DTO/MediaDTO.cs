using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MediaDTO
    {
        public int Id { get; set; }

        public string? Tipo { get; set; }

        public string Url { get; set; } = null!;

        public string? MimeType { get; set; }

        public long? SizeBytes { get; set; }

        public string? AltText { get; set; }

        public DateOnly? FechaCreacion { get; set; }
    }
}
