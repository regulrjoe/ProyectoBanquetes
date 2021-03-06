﻿namespace Banquetes
{
    partial class Invitados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invitados));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblInfoInvitado = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblListaInvitados = new System.Windows.Forms.Label();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lstInvitados = new System.Windows.Forms.ListBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(67, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "*Email:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(279, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 25);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarTodo.Location = new System.Drawing.Point(375, 203);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(151, 25);
            this.btnEliminarTodo.TabIndex = 1;
            this.btnEliminarTodo.Text = "Eliminar todos";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(172, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnterior.Location = new System.Drawing.Point(370, 234);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 25);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSiguiente.Location = new System.Drawing.Point(451, 234);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 25);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblInfoInvitado
            // 
            this.lblInfoInvitado.AutoSize = true;
            this.lblInfoInvitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblInfoInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoInvitado.ForeColor = System.Drawing.Color.White;
            this.lblInfoInvitado.Location = new System.Drawing.Point(12, 12);
            this.lblInfoInvitado.Name = "lblInfoInvitado";
            this.lblInfoInvitado.Size = new System.Drawing.Size(183, 18);
            this.lblInfoInvitado.TabIndex = 9;
            this.lblInfoInvitado.Text = "Información de invitado";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Location = new System.Drawing.Point(153, 253);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(22, 17);
            this.pnlInfo.TabIndex = 10;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblListaInvitados
            // 
            this.lblListaInvitados.AutoSize = true;
            this.lblListaInvitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblListaInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaInvitados.ForeColor = System.Drawing.Color.White;
            this.lblListaInvitados.Location = new System.Drawing.Point(276, 12);
            this.lblListaInvitados.Name = "lblListaInvitados";
            this.lblListaInvitados.Size = new System.Drawing.Size(139, 18);
            this.lblListaInvitados.TabIndex = 12;
            this.lblListaInvitados.Text = "Lista de Invitados";
            // 
            // pnlLista
            // 
            this.pnlLista.Location = new System.Drawing.Point(196, 253);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(22, 17);
            this.pnlLista.TabIndex = 11;
            this.pnlLista.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(29, 37);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(218, 26);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Ingrese el nombre completo y el E-mail de los\r\n invitados deseados para su evento" +
    "";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lstInvitados
            // 
            this.lstInvitados.FormattingEnabled = true;
            this.lstInvitados.Location = new System.Drawing.Point(279, 37);
            this.lstInvitados.Name = "lstInvitados";
            this.lstInvitados.Size = new System.Drawing.Size(247, 160);
            this.lstInvitados.TabIndex = 14;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(12, 234);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 25);
            this.Cancelar.TabIndex = 15;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Invitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 272);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.lstInvitados);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblListaInvitados);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.lblInfoInvitado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invitados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invitados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblInfoInvitado;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblListaInvitados;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstInvitados;
        private System.Windows.Forms.Button Cancelar;
    }
}