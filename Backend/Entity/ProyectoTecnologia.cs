using System;
using System.Collections.Generic;

namespace BE;

public partial class ProyectoTecnologia
{
    public int Id { get; set; }

    public int ProyectoId { get; set; }

    public int TecnologiaId { get; set; }

    public string? Nota { get; set; }

    public virtual Proyecto Proyecto { get; set; } = null!;

    public virtual Tecnologia Tecnologia { get; set; } = null!;
}
