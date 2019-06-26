using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUniversitario.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public virtual List<InscripcionesDetalle> Detalle { get; set; }
        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
        }

    }
}
