using System;
using System.Collections.Generic;

namespace BE;

public partial class Educacion
{
    public int Id { get; set; }

    public string? Institucion { get; set; }

    public string? Titulo { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public int PerfilId { get; set; }

    public virtual Perfil Perfil { get; set; } = null!;
}
