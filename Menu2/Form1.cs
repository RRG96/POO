using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Times New Roman", 28);
        }
       
        public void clearColor()
        {
            negroToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
        }

        public void clearStyle()
        {
            negritasToolStripMenuItem.Checked = false;
            cursivaToolStripMenuItem.Checked = false;
        }

        public void clearFont()
        {
            arialToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Interaction.InputBox("Ingresa una cadena", "Cambiar Texto");
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fue hecho por Rodrigo");
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            negroToolStripMenuItem.Checked = true;
            label1.ForeColor = Color.Black;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            azulToolStripMenuItem.Checked = true;
            label1.ForeColor = Color.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            verdeToolStripMenuItem.Checked = true;
            label1.ForeColor = Color.Green;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Times New Roman", 28);
            arialToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Comic Sans", 28);
            comicSansToolStripMenuItem.Checked = true;
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Courier", 28);
            courierToolStripMenuItem.Checked = true;
        }

        private void negritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearStyle();
            label1.Font = new Font("Bold", 28);
            negritasToolStripMenuItem.Checked = true;
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearStyle();
            label1.Font = new Font("Bold", 28);
            cursivaToolStripMenuItem.Checked = true;
        }
    }
}
