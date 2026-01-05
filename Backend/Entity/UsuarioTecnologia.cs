using System;
using System.Collections.Generic;

namespace BE;

public partial class UsuarioTecnologia
{
    public int Id { get; set; }

    public int? Nivel { get; set; }

    public int? AñosExp { get; set; }

    public string? CertUrl { get; set; }

    public int UsuarioId { get; set; }

    public int TecnologiaId { get; set; }

    public virtual Tecnologia Tecnologia { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
