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

        DataTable lista = new DataTable();
        int turno = 0;
        public Turno objTurno = new Turno();
        public Cliente objCliente = new Cliente();

        #endregion

        public Negocios.NegTurno objNegTurno = new Negocios.NegTurno();
        public Negocios.NegCliente objNegCliente = new Negocios.NegCliente();

        #region Constructor

        private void Turnero_Load(object sender, EventArgs e)
        {
            cmbDias.Enabled = false;
            cmbHorarios.Enabled = false;
        }

        public Turnero()
        {

            InitializeComponent();
            lista.Columns.Add("Turno", typeof(int));
            lista.Columns.Add("Servicio", typeof(string));
            lista.Columns.Add("Precio", typeof(string));
            lista.Columns.Add("Cliente", typeof(string));
            lista.Columns.Add("Días", typeof(string));
            lista.Columns.Add("Horarios", typeof(string));
            lista.Columns.Add("Peluquero", typeof(string));

            dg.DataSource = lista;

            
        }


        #endregion


        #region eventos

        private void button1_Click(object sender, EventArgs e) // boton de reservar turno
        {   
            objTurno.Dia = cmbDias.SelectedItem.ToString();
            objTurno.Horario = cmbHorarios.SelectedItem.ToString();
            objTurno.Peluquero = cmbPeluquero.SelectedItem.ToString();

            objCliente.Nombre = txtCliente.Text;

            objNegTurno.abmTurno("Alta", objTurno);
            objNegCliente.abmCliente(objCliente);

            Peluquero();
            ControlTxt();
        }


        private void button2_Click(object sender, EventArgs e) // boton de salir 
        {
            Application.Exit();
        }

        #endregion



        #region metodos

        private void Peluquero()
        {
            if (cmbDias.Text.Trim() == "martes" || cmbDias.Text.Trim() == "viernes")
            {

                if (cmbHorarios.Text.Trim() == "9:00hs" || cmbHorarios.Text.Trim() == "12:00hs" || cmbHorarios.Text.Trim() == "17:00hs" || cmbHorarios.Text.Trim() == "20:00hs")
                {
                    ListayPrecio();
                    lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 2";
                    
;
                }


            }

            else if (cmbDias.Text.Trim() == "miercoles" || cmbDias.Text.Trim() == "jueves")
            {

                if (cmbHorarios.Text.Trim() == "9:00hs" || cmbHorarios.Text.Trim() == "12:00hs" || cmbHorarios.Text.Trim() == "17:00hs" || cmbHorarios.Text.Trim() == "20:00hs")
                {
                    ListayPrecio();
                    lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 1";

                }

            }
           
            else if (cmbDias.Text.Trim() == "sabado"&& cmbHorarios.Text.Trim() == "9:00hs" || cmbHorarios.Text.Trim() == "12:00hs")
            {
                ListayPrecio();
                lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Dueño";

                
            }

            else
            {
                MessageBox.Show("SOLO SE ATIENDE LOS SABADOS DE 9:00hs A 13:00hs");
            }


        }

        private void ListayPrecio() // metodo que engloba: el metodo lista y el metodo precio
        {
            LISTA();
        }


        private void LISTA() // metodo lista
        {

            turno = turno + 1;

            lista.Rows.Add();

            lista.Rows[lista.Rows.Count - 1]["Turno"] = turno;
            lista.Rows[lista.Rows.Count - 1]["Días"] = cmbDias.Text;
            lista.Rows[lista.Rows.Count - 1]["Horarios"] = cmbHorarios.Text;
            lista.Rows[lista.Rows.Count - 1]["Cliente"] = txtCliente.Text;
            dg.DataSource = lista;



        }

        private void ControlTxt() // este metodo es para controlar los txt
        {
            txtCliente.Focus();
            txtCliente.Clear();
        }

        #endregion

        private void btModificar_Click(object sender, EventArgs e) //NO FUNCIONA
        {            
            objNegTurno.abmTurno("Modificar", objTurno);
        }

        private void BtCancelar_Click(object sender, EventArgs e) // NO ESTÁ TERMINADO
        {
            objNegTurno.abmTurno("Cancelar", objTurno);
        }

        private void cmbPeluquero_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosTurno dt = new DatosTurno();
            cmbDias.Enabled = true;
            DataTable temp = new DataTable();
            temp.Columns.Add("Dia", typeof(string));
            temp.Columns.Add("Horario", typeof(string));
            switch(cmbPeluquero.SelectedItem)
            {
                case "Ana Luque":
                    int V = 0;
                    temp = dt.TraerDisponibilidad("Ana Luque");
                    for(int i = 0; i < temp.Rows.Count; i++)
                    {
                        if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "9:00hs")
                        {
                            cmbHorarios.Items.RemoveAt(1);
                            V++;
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "12:00hs")
                        {
                            cmbHorarios.Items.RemoveAt(2);
                            V++;
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "17:00hs")
                        {
                            cmbHorarios.Items.RemoveAt(3);
                            V++;
                        }
                        else if(temp.Rows[i]["Dia"] == "Martes" && temp.Rows[i]["Horario"] == "20:00hs")
                        {
                            cmbHorarios.Items.RemoveAt(4);
                            V++;
                        }

                        if(V == 4)
                        {
                            cmbDias.Items.RemoveAt(1);
                        }
                    }
                    break;

                case "José Ramos":

                    break;

                case "Lucia Perez":

                    break;
            }
        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHorarios.Enabled = true;
        }
    }
}
