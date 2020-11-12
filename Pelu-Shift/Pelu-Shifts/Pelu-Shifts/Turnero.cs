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

namespace Pelu_Shifts
{
    public partial class Turnero : Form
    {
        #region propiedades

        DataTable lista = new DataTable();
        int turno = 0;


        #endregion



        #region Constructor

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
            
           
           

            if (txtDias.Text.Trim() == "martes" || txtDias.Text.Trim() == "viernes")
            {

                if (txthorarios.Text.Trim() == "9:00hs" || txthorarios.Text.Trim() == "12:00hs" || txthorarios.Text.Trim() == "17:00hs" || txthorarios.Text.Trim() == "20:00hs")
                {
                    ListayPrecio();
                    lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 2";
                    
;
                }


            }

            else if (txtDias.Text.Trim() == "miercoles" || txtDias.Text.Trim() == "jueves")
            {

                if (txthorarios.Text.Trim() == "9:00hs" || txthorarios.Text.Trim() == "12:00hs" || txthorarios.Text.Trim() == "17:00hs" || txthorarios.Text.Trim() == "20:00hs")
                {
                    ListayPrecio();
                    lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 1";

                }

            }
           
            else if (txtDias.Text.Trim() == "sabado"&& txthorarios.Text.Trim() == "9:00hs" || txthorarios.Text.Trim() == "12:00hs")
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
            Precio();
        }


        private void LISTA() // metodo lista
        {

            turno = turno + 1;

            lista.Rows.Add();

            lista.Rows[lista.Rows.Count - 1]["Turno"] = turno;
            lista.Rows[lista.Rows.Count - 1]["Servicio"] = txtservicios.Text;
            lista.Rows[lista.Rows.Count - 1]["Días"] = txtDias.Text;
            lista.Rows[lista.Rows.Count - 1]["Horarios"] = txthorarios.Text;
            lista.Rows[lista.Rows.Count - 1]["Cliente"] = txtNombreCliente.Text;
            dg.DataSource = lista;



        }


        private void Precio() // metodo precio
        {
            if (txtservicios.Text == "Corte de pelo")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$300";
            }
            else if (txtservicios.Text == "Lavado + Tintura")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$600";
            }
            else if (txtservicios.Text == "Peinados")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$800";
            }
            else if (txtservicios.Text == "Alisado")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$3500";
            }
            else if (txtservicios.Text == "Lavado + Brushing")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$500";
            }



            



        }

        private void ControlTxt() // este metodo es para controlar los txt
        {
            txtNombreCliente.Focus();
            txtNombreCliente.Clear();
            txtservicios.Text = "Servicios";
            txtDias.Text = "Días";
            txthorarios.Text = "Horarios";
        }


        #endregion


    }



}
