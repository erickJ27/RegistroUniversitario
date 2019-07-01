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
            var lista = new List<Estudiantes>();
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
                                lista = db.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriterioTextBox.Text);
                                lista = db.GetList(p => p.EstudianteId == id);
                                break;

                            case "Nombre":
                                lista = db.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                                break;


                            case "Balance":
                                double mont = Convert.ToInt32(CriterioTextBox.Text);
                                lista = db.GetList(p => Convert.ToDouble(p.Balance)  == mont);
                                break;

                            default:
                                break;
                        }
                        lista = lista.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
                    }
                    else
                    {

                        lista = db.GetList(p => true);
                        lista = lista.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
                    }

                    ConsultaDataGridView.DataSource = null;
                    ConsultaDataGridView.DataSource = lista;

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
                                lista = db.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriterioTextBox.Text);
                                lista = db.GetList(p => p.EstudianteId == id);
                                break;

                            case "Nombre":
                                lista= db.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                                break;


                            case "Balance":
                                double mont = Convert.ToInt32(CriterioTextBox.Text);
                                lista = db.GetList(p => Convert.ToDouble(p.Balance) == mont);
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        lista = db.GetList(p => true);
                    }

                    ConsultaDataGridView.DataSource = null;
                    ConsultaDataGridView.DataSource = lista;

                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }

            }


        }

        
    }
}
