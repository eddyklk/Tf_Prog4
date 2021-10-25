using System;
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
        private Form login;
        public string Usuario { get; set; }
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

        

        public void setLoginForm(Form Login)
        {
            this.login = Login;
            this.login.Hide();
        }

        private void MenuP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Close();
        }

        public void AgregarUsuario(string usuario)
        {
            this.Usuario = usuario;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta venta = new FrmVenta();
            venta.AgregarUsuario(this.Usuario);
            venta.ShowDialog();
            
        }
        private void tipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoProducto formTipoProducto = new FormTipoProducto();
            formTipoProducto.ShowDialog();
        }

        private void ajustesDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjusteProd formAjusteProd = new FormAjusteProd();
            formAjusteProd.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmREmpleado formREmpleado = new FrmREmpleado();
            formREmpleado.ShowDialog();
        }
    }
}
