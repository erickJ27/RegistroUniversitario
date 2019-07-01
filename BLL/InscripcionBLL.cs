using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroUniversitario.Entidades;
using RegistroUniversitario.DAL;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq.Expressions;

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
                Repositorio<Estudiantes> dbEst = new Repositorio<Estudiantes>(new DAL.Contexto());

                if (db.Inscripciones.Add(inscripciones) != null)
                {
                    var estudiantes = dbEst.Buscar(inscripciones.EstudianteId);

                    inscripciones.CalcularMonto();
                    estudiantes.Balance += inscripciones.Monto;
                    paso = db.SaveChanges() > 0;
                    dbEst.Modificar(estudiantes);
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public static bool Modificar(Inscripciones entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Repositorio<Estudiantes> dbE = new Repositorio<Estudiantes>();


            try
            {


                var anterior = new Repositorio<Inscripciones>().Buscar(entity.InscripcionId);
                var estudiantes = dbE.Buscar(entity.EstudianteId);

                estudiantes.Balance -= anterior.Monto;

                foreach (var item in anterior.Asignaturas)
                {
                    if (!entity.Asignaturas.Any(A => A.Id == item.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;

                    }

                }

                foreach (var item in entity.Asignaturas)
                {
                    if (item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }

                    else
                        db.Entry(item).State = EntityState.Modified;
                }


                entity.CalcularMonto();
                estudiantes.Balance += entity.Monto;
                dbE.Modificar(estudiantes);

                db.Entry(entity).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }
        public static Estudiantes Buscar(int id)
        {
            Estudiantes estudiantes = new Estudiantes();
            Contexto db = new Contexto();


            try
            {
                estudiantes = db.Estudiantes.Find(id);



            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al intentar Buscar");
            }
            finally
            {
                db.Dispose();
            }
            return estudiantes;

        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Repositorio<Estudiantes> dbEst = new Repositorio<Estudiantes>(new DAL.Contexto());
            try
            {
                var Inscripcion = db.Inscripciones.Find(id);
                var estudiante = dbEst.Buscar(Inscripcion.EstudianteId);
                estudiante.Balance = estudiante.Balance - Inscripcion.Monto;
                dbEst.Modificar(estudiante);
                db.Entry(Inscripcion).State = EntityState.Deleted;
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
        }
        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> inscripcion)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Inscripciones.Where(inscripcion).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }


    }
}
