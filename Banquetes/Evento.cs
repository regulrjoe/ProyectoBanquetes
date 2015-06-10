﻿using Banquetes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquetes
{
    public partial class Evento : Form
    {
        public Evento()
        {
            
            InitializeComponent();
        }

        public Evento(int folio)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 378, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Banquetes.Inicio.invitados.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                EventoClase evento = new EventoClase();
                string nombre = txtNombre.Text;
                string calle = txtCalle.Text;
                string colonia = txtColonia.Text;
                int Cp = int.Parse(txtCP.Text);
                string numero = txtNumero.Text;
                string hora = txtHora.Text;
                string comentario = txtComent.Text;
                DateTime fecha = dtpFecha.Value;


                //Crear un nuevo evento en la clase EventoClase
                EventoClase ev = new EventoClase();
                //evento.Crear(nombre, calle, colonia, Cp, numero, hora, comentario, fecha, ev);
                
            }
            catch (Exception) {
                MessageBox.Show("Lo sentimos, algo ha salido mal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Recibo recibo = new Recibo();
            recibo.Show();
            this.Hide();
        }

        

       
    }
}
