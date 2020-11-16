using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;

namespace Pelu_Shifts
{
    public partial class Turnero : Form
    {
        #region propiedades

        public Turno objTurno = new Turno();
        DataTable lista = new DataTable();

        #endregion

        public Negocios.NegTurno objNegTurno = new Negocios.NegTurno();

        #region Constructor

        private void Turnero_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cmbDias.Enabled = false;
            cmbHorarios.Enabled = false;

            DatosTurno dt = new DatosTurno();
            lista = dt.ListarTurnos();
            dg.DataSource = lista;
        }

        public Turnero()
        {
            InitializeComponent();
        }
        #endregion


        #region eventos

        private void button1_Click(object sender, EventArgs e) // boton de reservar turno
        {
            Verificar();

            objTurno.Dia = cmbDias.SelectedItem.ToString();
            objTurno.Horario = cmbHorarios.SelectedItem.ToString();
            objTurno.Peluquero = cmbPeluquero.SelectedItem.ToString();
            objTurno.Nombre = txtCliente.Text;

            objNegTurno.abmTurno("Alta", objTurno);

            DatosTurno dt = new DatosTurno();
            lista = dt.ListarTurnos();
            dg.DataSource = lista;

            cmbDias.SelectedIndex = 0;
            cmbPeluquero.SelectedIndex = 0;
            cmbHorarios.SelectedIndex = 0;

            ControlTxt();
        }


        private void button2_Click(object sender, EventArgs e) // boton de salir 
        {
            Application.Exit();
        }

        #endregion



        #region metodos

        private void ControlTxt() // este metodo es para controlar los txt
        {
            txtCliente.Focus();
            txtCliente.Clear();
        }

        #endregion

        private void btModificar_Click(object sender, EventArgs e)
        {
            objTurno.Nombre = txtCliente.Text;
            objTurno.Dia = cmbDias.SelectedItem.ToString();
            objTurno.Horario = cmbHorarios.SelectedItem.ToString();
            objTurno.Peluquero = cmbPeluquero.SelectedItem.ToString();
            objNegTurno.abmTurno("Modificar", objTurno);
            DatosTurno dt = new DatosTurno();
            lista = dt.ListarTurnos();
            dg.DataSource = lista;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            objTurno.Nombre = txtCliente.Text;
            objTurno.Dia = cmbDias.SelectedItem.ToString();
            objTurno.Horario = cmbHorarios.SelectedItem.ToString();
            objTurno.Peluquero = cmbPeluquero.SelectedItem.ToString();
            objNegTurno.abmTurno("Cancelar", objTurno);
            DatosTurno dt = new DatosTurno();
            lista = dt.ListarTurnos();
            dg.DataSource = lista;
        }
        #region cbmPeluquero
        private void cmbPeluquero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDias.Enabled = true;
        }
        #endregion
        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHorarios.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToLongDateString();
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void cmbHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Verificar
        public void Verificar()
        {
            DatosTurno dt = new DatosTurno();
            DataTable temp = new DataTable();
            temp.Columns.Add("Dia", typeof(string));
            temp.Columns.Add("Horario", typeof(string));
            switch(cmbPeluquero.SelectedItem)
            {
                case "Ana Luque":

                    temp = dt.TraerDisponibilidad("Ana Luque");
                    for(int i = 0; i < temp.Rows.Count; i++)
                    {
                        //Martes
                        if(temp.Rows[i]["Dia"].ToString() == "martes" && temp.Rows[i]["Horario"].ToString() == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Miercoles
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Jueves
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Viernes
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Sabado
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                    }
                    break;

                case "José Ramos":

                    temp = dt.TraerDisponibilidad("José Ramos");
                    for(int i = 0; i < temp.Rows.Count; i++)
                    {
                        //Martes
                        if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Miercoles
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Jueves
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Viernes
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Sabado
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                    }

                    break;

                case "Lucia Perez":

                    temp = dt.TraerDisponibilidad("Lucia Perez");
                    for(int i = 0; i < temp.Rows.Count; i++)
                    {
                        //Martes
                        if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Miercoles
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Miercoles" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Jueves
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Jueves" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Viernes
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Viernes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        //Sabado
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                        else if(temp.Rows[i]["Dia"] == "Sabado" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            MessageBox.Show("Este horario ya fue reservado");
                        }
                    }

                    break;
            }
        }
        #endregion

        private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCliente.Text = dg.CurrentRow.Cells[0].Value.ToString();
            cmbDias.SelectedItem = dg.CurrentRow.Cells[1].Value.ToString();
            cmbHorarios.SelectedItem = dg.CurrentRow.Cells[2].Value.ToString();
            cmbPeluquero.SelectedItem = dg.CurrentRow.Cells[3].Value.ToString();
        }
    }
}