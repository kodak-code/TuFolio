using System;
using System.Collections.Generic;

namespace BE;

public partial class ProyectoMedia
{
    public int Id { get; set; }

    public int ProyectoId { get; set; }

    public int MediaId { get; set; }

    public string? Proposito { get; set; }

    public virtual Media Media { get; set; } = null!;

    public virtual Proyecto Proyecto { get; set; } = null!;
}
