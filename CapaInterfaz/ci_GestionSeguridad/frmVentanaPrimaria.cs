﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaInterfaz.ci_GestionPersonal.frmPersonal;


namespace CapaInterfaz.ci_GestionPersonal
{
    public partial class frmVentanaPrimaria : Form
    {
        public frmVentanaPrimaria()
        {
            InitializeComponent();
        }

        private void proveedoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        frmAdministrarPersonal frmap = new frmAdministrarPersonal();
        private void registrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmap.Visible == true)
            //{
            //    return;
            //}
           // frmap.MdiParent = this;
            frmap.Show();
        }

        private void registrarPersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (frmap.Visible == true)
            //{
            //    return;
            //}
            //frmap.Parent = panel1;
            //frmap.Show();
        }

        private void frmVentanaPrimaria_Load(object sender, EventArgs e)
        {
           // string usuario = "Jordi Duran";
          //  toolStripStatusLabel1.Text = "Usuario: " + usuario;

            string fecha = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = "Fecha: " + fecha;



        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void administrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmap.Visible == true)
            {
                return;
            }
            //frmap.MdiParent = this;
            frmap.Show();
        }

        private void gestionDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Hora: "+DateTime.Now.ToLongTimeString();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void administrarPersonalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAdministrarPersonal frmap = new frmAdministrarPersonal();
            frmap.Show();
        }

    }
}
