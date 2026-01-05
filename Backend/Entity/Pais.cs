using System;
using System.Collections.Generic;

namespace BE;

public partial class Pais
{
    public int Id { get; set; }

    public string Iso2 { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SubDivision> SubDivisions { get; set; } = new List<SubDivision>();
}
