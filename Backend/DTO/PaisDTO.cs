using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaisDTO
    {
        public int Id { get; set; }

        public string Iso2 { get; set; } = null!;

        public string Nombre { get; set; } = null!;
    }
}
