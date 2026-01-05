using System;
using System.Collections.Generic;

namespace BE;

public partial class Auth
{
    public int Id { get; set; }

    public string? Proveedor { get; set; }

    public string? ProveedorUsuarioId { get; set; }

    public byte[]? PasswordHash { get; set; }

    public int IntentosFallidos { get; set; }

    public DateTime? BloqueoHasta { get; set; }

    public int UsuarioId { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
