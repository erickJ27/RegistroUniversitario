using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroUniversitario.Entidades;
using RegistroUniversitario.DAL;
using System.Data.Entity;

namespace RegistroUniversitario.BLL
{
    public class InscripcionBLL
    {

        public static bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Inscripciones.Add(inscripciones) != null)
                {
                    foreach(var item in inscripciones.Detalle)
                    {
                        db.Estudiantes.Find(item.EstudianteId).Balance += inscripciones.Monto;
                    }
                    paso = db.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
            
        }
       /* public static bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Repositorio<Estudiantes> dbE = new Repositorio<Estudiantes>();
            try
            {
                var estudiante = dbE.Buscar(EstudianteId);

                var anterior = new RepositorioBase<Inscripcion>().Buscar(entity.InscripcionId);


                db.Entry(inscripciones).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }*/
    }
}
