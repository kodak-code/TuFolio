using System;
using System.Collections.Generic;

namespace BE;

public partial class Tecnologia
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Categoria { get; set; }

    public string? Slug { get; set; }

    public string? IconoUrl { get; set; }

    public virtual ICollection<ProyectoTecnologia> ProyectoTecnologia { get; set; } = new List<ProyectoTecnologia>();

    public virtual ICollection<UsuarioTecnologia> UsuarioTecnologia { get; set; } = new List<UsuarioTecnologia>();
}
