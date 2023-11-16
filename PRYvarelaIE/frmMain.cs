﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PRYvarelaIE
{
    internal partial class frmMain : Form
    {

        public clsUser usuarioActual;

        public frmMain(clsUser usuarioActual)
        {
            InitializeComponent();

            if (usuarioActual != null)
            {
                this.usuarioActual = usuarioActual;
            }
            else
            {
                // Maneja el caso en el que usuarioActual sea null si es necesario
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                lblUsuarioMain.Text = usuarioActual.User;
            }

            if (usuarioActual.Rol != "Administrador")
            {
                gestiónToolStripMenuItem.Enabled = false;
            }

        }

        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void activosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmActivos fActivos = new frmActivos();
            fActivos.ShowDialog();
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProveedor frmRegProv = new frmRegistroProveedor();
            frmRegProv.ShowDialog();

            int idUsuarioActual = usuarioActual.Id;
            DateTime fechaLog = DateTime.Now.Date;
            string categoria = registroProveedor.Text;

            clsUser objMenuClick = new clsUser();
            objMenuClick.MenuLog(idUsuarioActual, fechaLog, categoria);
        }
    }
}
