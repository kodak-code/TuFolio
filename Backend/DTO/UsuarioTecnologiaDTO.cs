using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioTecnologiaDTO
    {
        public int Id { get; set; }

        public int? Nivel { get; set; }

        public int? AñosExp { get; set; }

        public string? CertUrl { get; set; }

        public int UsuarioId { get; set; }

        public string? UsuarioNombre { get; set; }

        public int TecnologiaId { get; set; }

        public string? TecnologiaNombre { get; set; }

    }
}
