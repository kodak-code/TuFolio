using System;
using System.Collections.Generic;

namespace BE;

public partial class Media
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string Url { get; set; } = null!;

    public string? MimeType { get; set; }

    public long? SizeBytes { get; set; }

    public string? AltText { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public virtual ICollection<ProyectoMedia> ProyectoMedia { get; set; } = new List<ProyectoMedia>();
}
