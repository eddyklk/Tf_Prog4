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
    public partial class FrmCTipoProductos : Form
    {
        public ClassDatos Datos = new ClassDatos();

        public FrmCTipoProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string srtSql = $"SELECT * FROM TipoProductos WHERE NomTipoProd LIKE '%{textBox1.Text}%'";
            DataTable data = Datos.EjecutarQuery(srtSql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }
    }
}
