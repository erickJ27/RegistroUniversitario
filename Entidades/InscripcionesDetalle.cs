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
        public int AsignaturaId { get; set; }

        public int EstudianteId { get; set; }

        //Todo:Falta todavia algun otro campo

        public InscripcionesDetalle()
        {
            Id = 0;
            AsignaturaId = 0;
            EstudianteId = 0;
        }

        public InscripcionesDetalle(int Id,int AsignaturaId,int EstudianteId)
        {
            this.Id = Id;
            this.AsignaturaId =AsignaturaId;
            this.EstudianteId =EstudianteId;
        }
    }
}
