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
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
            FiltroComboBox.Text = "Todo";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiantes>();
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>();
            if (FiltrarFechaCheckBox.Checked == true)
            {
                try
                {
                    if (CriterioTextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltroComboBox.Text)
                        {
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriterioTextBox.Text);
                                listado = db.GetList(p => p.EstudianteId == id);
                                break;

                            case "Nombre":
                                listado = db.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                                break;


                            case "Balance":
                                double mont = Convert.ToInt32(CriterioTextBox.Text);
                                listado = db.GetList(p => Convert.ToDouble(p.Balance)  == mont);
                                break;

                            default:
                                break;
                        }
                        listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
                    }
                    else
                    {

                        listado = db.GetList(p => true);
                        listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
                    }

                    ConsultaDataGridView.DataSource = null;
                    ConsultaDataGridView.DataSource = listado;

                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }


            }
            else
            {
                try
                {

                    if (CriterioTextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltroComboBox.Text)
                        {
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriterioTextBox.Text);
                                listado = db.GetList(p => p.EstudianteId == id);
                                break;

                            case "Nombre":
                                listado = db.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                                break;


                            case "Balance":
                                double mont = Convert.ToInt32(CriterioTextBox.Text);
                                listado = db.GetList(p => Convert.ToDouble(p.Balance) == mont);
                                break;

                            default:
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
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }

            }


        }

        
    }
}
