using System;
using System.Collections.Generic;

namespace BE;

public partial class SubDivision
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public int PaisId { get; set; }

    public virtual Pais Pais { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
