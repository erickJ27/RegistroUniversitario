using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroUniversitario.BLL;
using RegistroUniversitario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUniversitario.BLL.Tests
{
    [TestClass()]
    public class RepositorioTests
    {
        [TestMethod()]
        public void AsignaturaGuardarTest()
        {
            Asignaturas a = new Asignaturas();
            a.AsignaturaId = 1;
            a.Descripcion = "lengua espanola";
            a.Creditos = 5;

            Repositorio<Asignaturas> r = new Repositorio<Asignaturas>();
            bool paso = false;
            paso = r.Guardar(a);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void AsignaturaModificarTest()
        {
            Repositorio<Asignaturas> repositorio = new Repositorio<Asignaturas>();
            bool paso = false;
            Asignaturas a = repositorio.Buscar(1);
            a.Creditos = 4;
            paso = repositorio.Modificar(a);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void AsignaturasBuscarTest()
        {
            Repositorio<Asignaturas> repositoriobase = new Repositorio<Asignaturas>();
            Asignaturas a = repositoriobase.Buscar(1);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void AsignaturasGetListTest()
        {
            Repositorio<Asignaturas> repositorio = new Repositorio<Asignaturas>();
            List<Asignaturas> lista = new List<Asignaturas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EstudianteGuardarTest()
        {
            Estudiantes e = new Estudiantes();
            e.EstudianteId = 1;
            e.FechaIngreso = DateTime.Now;
            e.Nombres = "Johnsiel";
            e.Balance = 2000;

            Repositorio<Estudiantes> r = new Repositorio<Estudiantes>();
            bool paso = false;
            paso = r.Guardar(e);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudianteModificarTest()
        {
            Repositorio<Estudiantes> repositorio = new Repositorio<Estudiantes>();
            bool paso = false;
            Estudiantes e = repositorio.Buscar(1);
            e.Nombres = "Maria";
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudianteBuscarTest()
        {
            Repositorio<Estudiantes> repositoriobase = new Repositorio<Estudiantes>();
            Estudiantes e = repositoriobase.Buscar(1);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void EstudianteGetListTest()
        {
            Repositorio<Estudiantes> repositorio = new Repositorio<Estudiantes>();
            List<Estudiantes> lista = new List<Estudiantes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void InscripcionGuardarTest()
        {
            Inscripciones i = new Inscripciones();
            i.InscripcionId = 1;
            i.EstudianteId = 1;
            i.Fecha = DateTime.Now;
            i.PrecioCreditos = 2000;


            Repositorio<Inscripciones> r = new Repositorio<Inscripciones>();
            bool paso = false;
            paso = r.Guardar(i);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionModificarTest()
        {
            Repositorio<Inscripciones> repositorio = new Repositorio<Inscripciones>();
            bool paso = false;
            Inscripciones i = repositorio.Buscar(1);
            i.PrecioCreditos = 200;
            paso = repositorio.Modificar(i);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionBuscarTest()
        {
            Repositorio<Inscripciones> repositoriobase = new Repositorio<Inscripciones>();
            Inscripciones i = repositoriobase.Buscar(1);
            Assert.IsNotNull(i);
        }

        [TestMethod()]
        public void InscripcionGetListTest()
        {
            Repositorio<Inscripciones> repositorio = new Repositorio<Inscripciones>();
            List<Inscripciones> lista = new List<Inscripciones>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void AsignaturaEliminarTest()
        {
            Repositorio<Asignaturas> repositoriobase = new Repositorio<Asignaturas>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudiantesEliminarTest()
        {
            Repositorio<Estudiantes> repositoriobase = new Repositorio<Estudiantes>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionEliminarTest()
        {
            Repositorio<Inscripciones> repositoriobase = new Repositorio<Inscripciones>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);

        }
    }
    
}