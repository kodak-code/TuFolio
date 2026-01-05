using System;
using System.Collections.Generic;

namespace BE;

public partial class Perfil
{
    public int Id { get; set; }

    public string? NombrePublico { get; set; }

    public string? Titulo { get; set; }

    public string? Biografia { get; set; }

    public string? AvatarUrl { get; set; }

    public bool? Pais { get; set; }

    public int UsuarioId { get; set; }

    public virtual ICollection<Educacion> Educacions { get; set; } = new List<Educacion>();

    public virtual ICollection<ExperienciaLaboral> ExperienciaLaborals { get; set; } = new List<ExperienciaLaboral>();

    public virtual ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

    public virtual Usuario Usuario { get; set; } = null!;
}
