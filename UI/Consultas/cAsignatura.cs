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

namespace RegistroUniversitario.UI.Consultas
{
    public partial class cAsignatura : Form
    {
        public cAsignatura()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asignaturas>();
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.Text)
                {
                    case "Todo":
                        listado = db.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = db.GetList(p => p.AsignaturaId == id);
                        break;

                    case "Descripcion":
                        listado = db.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                }

            }
            else
            {
                listado = db.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

        }
    }
}
