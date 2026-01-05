using System;
using System.Collections.Generic;

namespace BE;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string Gmail { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public bool Activo { get; set; }

    public bool Verificado { get; set; }

    public int? SubDivision { get; set; }

    public virtual Auth? Auth { get; set; }

    public virtual Perfil? Perfil { get; set; }

    public virtual SubDivision? SubDivisionNavigation { get; set; }

    public virtual ICollection<UsuarioRol> UsuarioRols { get; set; } = new List<UsuarioRol>();

    public virtual ICollection<UsuarioTecnologia> UsuarioTecnologia { get; set; } = new List<UsuarioTecnologia>();
}
