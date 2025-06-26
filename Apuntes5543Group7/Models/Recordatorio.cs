using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes5543Group7.Models
{
    public class Recordatorio
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Texto { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Activo { get; set; }
    }
}