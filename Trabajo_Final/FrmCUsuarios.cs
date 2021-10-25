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
    public partial class FrmCUsuarios : Form
    {
        public ClassDatos Datos = new ClassDatos();
        public FrmCUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string srtSql = $"Select NomUsuario, NombreCompleto, EstadoUsu, NombreRol, IdEmp FROM Usuarios usu inner join Roles rol on usu.IdRol = rol.IdRol WHERE NombreCompleto LIKE '%{textBox1.Text}%'";
            DataTable data = Datos.EjecutarQuery(srtSql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
