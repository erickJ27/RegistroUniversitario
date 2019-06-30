using RegistroUniversitario.BLL;
using RegistroUniversitario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUniversitario.UI.Registros
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            NombreTextBox.Text = string.Empty;
            BalanceNumericUpDown.Value = 0;

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Estudiantes LlenarClase()
        {
          
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = (int)IdNumericUpDown.Value;
            estudiantes.FechaIngreso = FechaIngresoDateTimePicker.Value;
            estudiantes.Nombres = NombreTextBox.Text;

            estudiantes.Balance = BalanceNumericUpDown.Value;

            return estudiantes;
        }

        private void LlenarCampo(Estudiantes estudiante)
        {

            IdNumericUpDown.Value = estudiante.EstudianteId;
            FechaIngresoDateTimePicker.Value = estudiante.FechaIngreso;
            NombreTextBox.Text = estudiante.Nombres;
            BalanceNumericUpDown.Value = estudiante.Balance;
            
            

        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            
            
                if (NombreTextBox.Text == string.Empty)
                {
                    MyErrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                    NombreTextBox.Focus();
                    paso = false;
                }
                
            

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>();
            Estudiantes productos = db.Buscar((int)IdNumericUpDown.Value);
            return (productos != null);

        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            bool paso = false;
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>();
            Estudiantes estudiantes = new Estudiantes();

            if (!Validar())
                return;
            estudiantes = LlenarClase();
            
            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(estudiantes);
                
                   
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(estudiantes);
            }

            if (!ExisteEnLaBaseDeDatos())
            {
                if (paso)
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (paso)
                    MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



                
            

            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();

            

            if (db.Eliminar(id))

                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar un usuario que no existe");


        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiantes = new Estudiantes();
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>();
            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();
            estudiantes = db.Buscar(id);

            if (estudiantes != null)
            {
                LlenarCampo(estudiantes);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }
    }
}
