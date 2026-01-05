using System;
using System.Collections.Generic;

namespace BE;

public partial class ExperienciaLaboral
{
    public int Id { get; set; }

    public string? Empresa { get; set; }

    public string? Puesto { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? Seniority { get; set; }

    public string? Descripcion { get; set; }

    public int PerfilId { get; set; }

    public virtual Perfil Perfil { get; set; } = null!;
}
