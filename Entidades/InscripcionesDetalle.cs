using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUniversitario.Entidades
{
    public class InscripcionesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }

        public decimal SubTotal { get; set; }


        public InscripcionesDetalle()
        {
            Id = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            SubTotal = 0;
        }

        public InscripcionesDetalle(int Id,int InscripcionId,int AsignaturaId,decimal SubTotal)
        {
            this.Id = Id;
            this.InscripcionId = InscripcionId;
            this.AsignaturaId =AsignaturaId;
            this.SubTotal = SubTotal;
        }
    }
}
