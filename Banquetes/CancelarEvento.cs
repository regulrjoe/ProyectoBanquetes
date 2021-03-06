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
    public partial class CancelarEvento : Form
    {
        private char form;
        private int folio;
        public CancelarEvento(int fol, char comingFrom)
        {
            InitializeComponent();
            form = comingFrom;
            folio = fol;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 300, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            bool existeComentario;
            string comentario = txtComentario.Text;
            EventoClase evCl = new EventoClase();
            if (string.IsNullOrWhiteSpace(comentario))
                existeComentario = false;
            else
                existeComentario = true;

            evCl.ActualizarStatus(folio, 3, existeComentario, comentario);
            
            MessageBox.Show("Evento cancelado.");
            this.Dispose();
        }
    }
}
