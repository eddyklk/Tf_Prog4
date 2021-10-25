using Registros;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            FrmVenta venta = new FrmVenta();
            venta.ShowDialog();
        }

    
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            
            ClassDatos Datos = new ClassDatos();
            if (Datos.Ingresar(TxtUsuario.Text, TxtContra.Text) == true)
            {
                MenuP Formulario = new MenuP();
                Formulario.AgregarUsuario(TxtUsuario.Text);
                Formulario.setLoginForm(this);
                Formulario.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrecta, Por favor revisar");
                TxtUsuario.Clear();
                TxtContra.Clear();
                TxtUsuario.Focus();
            }

        }

        private void TxtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnIniciar_Click(sender, e);
            }
        }
    }
}
