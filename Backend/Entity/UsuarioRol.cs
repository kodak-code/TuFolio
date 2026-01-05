using System;
using System.Collections.Generic;

namespace BE;

public partial class UsuarioRol
{
    public int Id { get; set; }

    public int RolId { get; set; }

    public int UsuarioId { get; set; }

    public virtual Rol Rol { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
