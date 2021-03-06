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
    public partial class MenuP : Form
    {
        private Form login;
        public string Usuario { get; set; }
        public int IdRol { get; set; } = 0;
        private ClassDatos Datos = new ClassDatos();
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
            buscarUsuario();
            permiso();
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

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCVenta formCVenta = new FrmCVenta();
            formCVenta.ShowDialog();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCArticulos formCArticulos = new FrmCArticulos();
            formCArticulos.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCCliente formClientes = new frmCCliente();
            formClientes.ShowDialog();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCUsuarios formUsuarios = new FrmCUsuarios();
            formUsuarios.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCEmpleados formEmpleados = new FrmCEmpleados();
            formEmpleados.ShowDialog();
        }

        private void tipoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCTipoProductos formTipoProductos = new FrmCTipoProductos();
            formTipoProductos.ShowDialog();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRClientes formRClientes = new FormRClientes();
            formRClientes.ShowDialog();
        }

        private void buscarUsuario()
        {
            if (!String.IsNullOrEmpty(this.Usuario))
            {
                string strSql = $" SELECT NombreCompleto, IdEmp, IdRol FROM Usuarios WHERE NomUsuario = '{this.Usuario}'";
                DataTable data = Datos.EjecutarQuery(strSql);
                this.IdRol = (int)data.Rows[0][2];              
            }
        }

        private void permiso()
        {
            if (this.IdRol != 1)
            {
                menuStrip1.Items[0].Visible = false;
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[4].Visible = false;
                menuStrip1.Items[5].Visible = false;

            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRUsuario formUsuario = new FrmRUsuario();
            formUsuario.ShowDialog();
        }
    }
}
