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
    public partial class FormTipoProducto : Form
    {
        private ClassDatos datos = new ClassDatos();

        public FormTipoProducto()
        {
            InitializeComponent();
            TxtmodIdtipPro.Text = "0";
        }

        private void btnProGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Guardar los datos?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string srtSql = $"EXEC DBO.SP_Insertar_TipoProducto {TxtmodIdtipPro.Text}, '{TxtmodtipPro.Text}'";
                DataTable data = datos.EjecutarQuery(srtSql);
                dgvTipoProd.DataSource = null;
                dgvTipoProd.DataSource = data;
            }
        }

        private void BtnProSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnProEditar_Click(object sender, EventArgs e)
        {
            if (dgvTipoProd.SelectedRows.Count > 0)
            {
                TxtmodIdtipPro.Text = dgvTipoProd.CurrentRow.Cells["IdTipoProd"].Value.ToString();
                TxtmodtipPro.Text = dgvTipoProd.CurrentRow.Cells["NomTipoProd"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void BtnProConsultar_Click(object sender, EventArgs e)
        {
            dgvTipoProd.DataSource = null;
            dgvTipoProd.DataSource = datos.Consulta("SELECT IdTipoProd, NomTipoProd FROM TipoProductos ORDER BY IdTipoProd DESC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtmodIdtipPro.Text = "0";
            TxtmodtipPro.Clear();
        }
    }
    
}
