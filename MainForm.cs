using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroUniversitario.UI.Registros;
using RegistroUniversitario.UI.Consultas;

namespace RegistroUniversitario
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes ver= new rEstudiantes();

            ver.Show();

        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas ver = new rAsignaturas();
            ver.Show();
        }

        private void InscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripciones ver =new rInscripciones();
            ver.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsignaturas ver = new cAsignaturas();
            ver.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiantes ver = new cEstudiantes();
            ver.Show();
        }
    }
}
