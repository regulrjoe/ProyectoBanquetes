﻿using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 518, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarEvento cancelar = new CancelarEvento(0, 'a');
            cancelar.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grpFecha.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            grpFecha.Visible = false;
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
