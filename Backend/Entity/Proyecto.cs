using System;
using System.Collections.Generic;

namespace BE;

public partial class Proyecto
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

    public virtual Portfolio Portfolio { get; set; } = null!;

    public virtual ICollection<ProyectoMedia> ProyectoMedia { get; set; } = new List<ProyectoMedia>();

    public virtual ICollection<ProyectoTecnologia> ProyectoTecnologia { get; set; } = new List<ProyectoTecnologia>();
}
