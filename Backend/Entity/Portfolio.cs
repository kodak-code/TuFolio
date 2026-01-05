using System;
using System.Collections.Generic;

namespace BE;

public partial class Portfolio
{
    public int Id { get; set; }

    public string SlugPublico { get; set; } = null!;

    public string Visibilidad { get; set; } = null!;

    public DateOnly? FechaPublicacion { get; set; }

    public int PerfilId { get; set; }

    public virtual Perfil Perfil { get; set; } = null!;

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();
}
