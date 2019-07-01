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
    public partial class rInscripciones : Form
    {
        
        public List<InscripcionesDetalle> Detalle { get; set; }
        public rInscripciones()
        {
            InitializeComponent();
            LlenarAsignaturas();
            LLenarEstudiantes();
            EstudianteComboBox.Text = null;
            AsignaturaComboBox.Text = null;
            this.Detalle = new List<InscripcionesDetalle>();
        }
        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }
        private void LlenarAsignaturas()
        {
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>(new DAL.Contexto());
            var lista = new List<Asignaturas>();
            lista = db.GetList(p => true);
            AsignaturaComboBox.DataSource = lista;
            AsignaturaComboBox.DisplayMember = "Descripcion";
            AsignaturaComboBox.ValueMember = "AsignaturaId";

        }

        private void LLenarEstudiantes()
        {
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>(new DAL.Contexto());
            var lista = new List<Estudiantes>();
            lista= db.GetList(l => true);
            EstudianteComboBox.DataSource = lista;
            EstudianteComboBox.DisplayMember = "Nombre";
            EstudianteComboBox.ValueMember = "EstudianteId";
        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value= DateTime.Now;
            PrecioCreditoNumericUpDown.Value = 0;
            MontoTextBox.Text = string.Empty;
            AsignaturaComboBox.Text = string.Empty;
            EstudianteComboBox.Text = string.Empty;

            this.Detalle = new List<InscripcionesDetalle>();
            MyErrorProvider.Clear();
            CargarGrid();

        }
        private bool Validar()
        {

            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(EstudianteComboBox.Text))
            {
                MyErrorProvider.SetError(EstudianteComboBox, "El campo Estudiante no puede estar vacio");
                EstudianteComboBox.Focus();
                paso = false;
            }

            if (PrecioCreditoNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(PrecioCreditoNumericUpDown, "Debes elegir un monto de creditos");
                PrecioCreditoNumericUpDown.Focus();
                paso = false;
            }

            if (Detalle.Count == 0)
            {
                MyErrorProvider.SetError(AsignaturaComboBox, "La inscripcion por lo menos debe tener una asignatura");
                AsignaturaComboBox.Focus();
                paso = false;
            }


            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Inscripciones LlenarClase()
        {
            Inscripciones inscripciones = new Inscripciones();
            inscripciones.InscripcionId = (int)IdNumericUpDown.Value;
            inscripciones.Fecha = FechaDateTimePicker.Value;
            inscripciones.PrecioCreditos = PrecioCreditoNumericUpDown.Value;
            inscripciones.Monto = Convert.ToDecimal(MontoTextBox.Text);

            inscripciones.Asignaturas = this.Detalle;

            return inscripciones;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Inscripciones> db = new Repositorio<Inscripciones>(new DAL.Contexto());
            Inscripciones inscripciones = db.Buscar((int)IdNumericUpDown.Value);
            return (inscripciones != null);

        }
        private void LlenaCampo(Inscripciones inscripciones)
        {
            IdNumericUpDown.Value = inscripciones.InscripcionId;
            EstudianteComboBox.Text = inscripciones.EstudianteId.ToString();
            MontoTextBox.Text = inscripciones.Monto.ToString();
            PrecioCreditoNumericUpDown.Value = (decimal)inscripciones.PrecioCreditos;
            FechaDateTimePicker.Value = inscripciones.Fecha;
            this.Detalle = inscripciones.Asignaturas;
            CargarGrid();

        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripciones;
            bool paso = false;

            if (!Validar())
                return;

            inscripciones = LlenarClase();
            inscripciones.CalcularMonto();
            if (IdNumericUpDown.Value == 0)
            {
                paso = InscripcionBLL.Guardar(inscripciones);


            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = InscripcionBLL.Modificar(inscripciones);
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

        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>(new DAL.Contexto());
            if (AsignaturaComboBox.Text == "")
            {
                MyErrorProvider.SetError(AsignaturaComboBox, "Debe elegir una asignatura");
                AsignaturaComboBox.Focus();

            }
            else
            {


                Asignaturas asignatura = db.Buscar((int)AsignaturaComboBox.SelectedValue);
                if (DetalleDataGridView.DataSource != null)
                    this.Detalle = (List<InscripcionesDetalle>)DetalleDataGridView.DataSource;

                this.Detalle.Add(new InscripcionesDetalle()
                {
                    InscripcionId = (int)IdNumericUpDown.Value,
                    AsignaturaId = (int)AsignaturaComboBox.SelectedValue,
                    Id = 0,
                    SubTotal = (asignatura.Creditos * PrecioCreditoNumericUpDown.Value)
                });

                CargarGrid();
            }
        }

        private void EliminarFilaButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                //remover la fila
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Inscripciones> db = new Repositorio<Inscripciones>(new DAL.Contexto());
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();
            if (InscripcionBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar, porque no existe");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Inscripciones> db = new Repositorio<Inscripciones>(new DAL.Contexto());
            int id;
            Inscripciones inscripciones = new Inscripciones();

            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();

            inscripciones = db.Buscar(id);

            if (inscripciones != null)
            {
                LlenaCampo(inscripciones);
            }
            else
            {
                MessageBox.Show("Inscripcion no existe");
            }
        }
    }
}
