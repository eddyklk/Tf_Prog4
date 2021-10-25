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
    public partial class FrmREmpleado : Form
    {
        private ClassDatos datos = new ClassDatos();
        public FrmREmpleado()
        {
            InitializeComponent();
            cargarComboBoxTipoEmpleado();
            cargarComboBoxEstado();
        }

        private void FrmREmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Empleados ORDER BY IdEmp DESC";
            DataTable data = datos.EjecutarQuery(strSql);
            dgvRegArt.DataSource = null;
            dgvRegArt.DataSource = data;
        }
        private void cargarComboBoxTipoEmpleado()
        {
            string strSql = "SELECT IdTipoEmp, NomTipoEmp, EstadoEmp FROM Tipo_Empleados ";
            DataTable dato = datos.EjecutarQuery(strSql);
            cbIdTipoEmpl.DisplayMember = "NomTipoEmp";
            cbIdTipoEmpl.ValueMember = "IdTipoEmp";
            cbIdTipoEmpl.DataSource = dato;
        }
        private void cargarComboBoxEstado()
        {
            List<comboBox> lista = new List<comboBox> {
                new comboBox{ sId = "A", valor = "Activo"},
                new comboBox{ sId = "D", valor = "Desactivado"}
            };

            cbEstadoEmp.DisplayMember = "valor";
            cbEstadoEmp.ValueMember = "sId";
            cbEstadoEmp.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRegArt.SelectedRows.Count > 0)
            {

                TxtIdEmp.Text = dgvRegArt.CurrentRow.Cells["IdEmp"].Value.ToString();
                TxtNomEmp.Text = dgvRegArt.CurrentRow.Cells["NomEmp"].Value.ToString();
                TxtApeEmp.Text = dgvRegArt.CurrentRow.Cells["ApeEmp"].Value.ToString();
                TxtDirecEmp.Text = dgvRegArt.CurrentRow.Cells["DirecEmp"].Value.ToString();
                TxtTelEmp.Text = dgvRegArt.CurrentRow.Cells["TelEmp"].Value.ToString();
                TxtCelEmp.Text = dgvRegArt.CurrentRow.Cells["CelEmp"].Value.ToString();
                cbIdTipoEmpl.SelectedValue = dgvRegArt.CurrentRow.Cells["IdTipEmp"].Value.ToString();
                cbEstadoEmp.SelectedValue = dgvRegArt.CurrentRow.Cells["EstadoEmp"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdEmp.Text = "0";
            TxtNomEmp.Clear();
            TxtApeEmp.Clear();
            TxtDirecEmp.Clear();
            TxtTelEmp.Clear();
            TxtCelEmp.Clear();
            cbIdTipoEmpl.SelectedValue = 1;
            cbEstadoEmp.SelectedValue = "A";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Guardar los datos?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string srtSql = $"EXEC DBO.SP_Insertar_Empleado {TxtIdEmp.Text}, '{TxtNomEmp.Text}', '{TxtApeEmp.Text}', '{TxtDirecEmp.Text}',1,'{TxtTelEmp.Text}','{TxtCelEmp.Text}', {cbIdTipoEmpl.SelectedValue},'{cbEstadoEmp.SelectedValue}'";
                DataTable data = datos.EjecutarQuery(srtSql);
                dgvRegArt.DataSource = null;
                dgvRegArt.DataSource = data;
            }
        }
    }
    class comboBox
    {
        public  int Id { get; set; }
        public string valor { get; set; }
        public string sId { get; set; }
    }
}
