﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.cd_GestionPersonal;
using CapaInterfaz.ci_GestionPersonal.frmPersonal;
namespace CapaInterfaz.ci_GestionPersonal.frmPersonal
{
    public partial class frmAdministrarPersonal : Form
    {
        public frmAdministrarPersonal()
        {
            InitializeComponent();
        }
       

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarPersonal frmrp = new frmRegistrarPersonal();
            frmrp.ShowDialog();

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAdministrarPersonal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PersonalCd.ObtenerPresonal("");
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PersonalCd.ObtenerPresonal(textBuscar.Text);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("¿Está seguro que desea eliminar la persona?", "Información del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog == DialogResult.Yes){
                string cedula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                PersonalCd.EliminarPersonalCedula(cedula);
                dataGridView1.DataSource = PersonalCd.ObtenerPresonal("");           
            }
            
        }
        //PersonalCd pcd = new PersonalCd();
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            byte[] foto;
            

            string cedula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string apellidos = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string cargo = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string titulo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string correo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string sexo = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string ciudad = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string direccion = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string telefono = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string tipo = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            foto = PersonalCd.getImageById(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            
            
            frmModificarPersonal frmdp = new frmModificarPersonal(cedula, nombre, apellidos,cargo,titulo, correo,
            sexo, ciudad, direccion, telefono, tipo, foto);
            frmdp.Show();






        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PersonalCd.ObtenerPresonal("");  
        }
    }
    }