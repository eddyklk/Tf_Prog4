﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final
{
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }

        private void sobreNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Trabajo Final de Programacion 4 \n\n 17-2085 \t eddy valerio  \n 11-1111 \t Armando \n 11-1111 \t Jhon  ";
            MessageBox.Show(text);

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRArticulos formRArticulos = new FormRArticulos();
            formRArticulos.ShowDialog();
        }
    }
}