using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroUniversitario.BLL;
using RegistroUniversitario.Entidades;


namespace RegistroUniversitario.UI.Registros
{
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CreditosNumericUpDown.Value = 0;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Asignaturas LlenarClase()
        {
            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = (int)IdNumericUpDown.Value;
            asignatura.Descripcion = DescripcionTextBox.Text;
            asignatura.Creditos = (int)CreditosNumericUpDown.Value;

            return asignatura;
        }
        private void LlenarCampo(Asignaturas asignaturas)
        {
            IdNumericUpDown.Value = asignaturas.AsignaturaId;
            DescripcionTextBox.Text = asignaturas.Descripcion;
            CreditosNumericUpDown.Value = asignaturas.Creditos;

        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();


            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (CreditosNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CreditosNumericUpDown, "El campo Creditos no puede estar vacio");
                CreditosNumericUpDown.Focus();
                paso = false;
            }
            if (CreditosNumericUpDown.Value > 6)
            {
                MyErrorProvider.SetError(CreditosNumericUpDown, "El campo Creditos no puede ser mayor de 6");
                CreditosNumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>();
            Asignaturas asignaturas = db.Buscar((int)IdNumericUpDown.Value);
            return (asignaturas != null);

        }
        

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();

            if (!Validar())
                return;
            asignaturas = LlenarClase();

            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(asignaturas);


            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una asignaturaS que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(asignaturas);
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
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar una asignatura que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();



            if (db.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar una asignatura que no existe");


        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Asignaturas asignaturas = new Asignaturas();
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>();
            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();
            asignaturas = db.Buscar(id);

            if (asignaturas != null)
            {
                LlenarCampo(asignaturas);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }
    }
}
