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
    public partial class FrmRUsuario : Form
    {
        private ClassDatos datos = new ClassDatos();

        public FrmRUsuario()
        {
            InitializeComponent();
            cargarComboBoxEstado();
            cargarComboBoxEmpleado();
            cargarComboBoxRol();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Dgv1.DataSource = null;
            Dgv1.DataSource = datos.Consulta("SELECT * FROM Usuarios");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombreCompleto.Clear();
            TxtNomUsuario.Clear();
            TxtClave.Clear();
            cmbEmpleado.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbRol.SelectedIndex = 0;
        }
        private void cargarComboBoxEstado()
        {
            List<comboBox> lista = new List<comboBox> {
                new comboBox{ sId = "A", valor = "Activo"},
                new comboBox{ sId = "D", valor = "Desactivado"}
            };

            cmbEstado.DisplayMember = "valor";
            cmbEstado.ValueMember = "sId";
            cmbEstado.DataSource = lista;
        }
        private void cargarComboBoxEmpleado()
        {
            string Query = "SELECT IdEmp, NomEmp + ' ' + ApeEmp AS NombreCompleto FROM Empleados";
            cmbEmpleado.DisplayMember = "NombreCompleto";
            cmbEmpleado.ValueMember = "IdEmp";
            cmbEmpleado.DataSource = datos.EjecutarQuery(Query);
        }
        private void cargarComboBoxRol()
        {
            string Query = "SELECT IdRol, NombreRol FROM Roles";
            cmbRol.DisplayMember = "NombreRol";
            cmbRol.ValueMember = "IdRol";
            cmbRol.DataSource = datos.EjecutarQuery(Query);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                TxtNombreCompleto.Text = Dgv1.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                TxtNomUsuario.Text = Dgv1.CurrentRow.Cells["NomUsuario"].Value.ToString();
                TxtClave.Text = Dgv1.CurrentRow.Cells["Claveusu"].Value.ToString();
                cmbEmpleado.SelectedValue = Dgv1.CurrentRow.Cells["IdEmp"].Value.ToString();
                cmbRol.SelectedValue = Dgv1.CurrentRow.Cells["IdRol"].Value.ToString();
                cmbEstado.SelectedValue = Dgv1.CurrentRow.Cells["EstadoUsu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Guardar los datos?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string srtSql = $"EXEC DBO.SP_Insertar_Usuario '{TxtNomUsuario.Text}', '{TxtClave.Text}', '{TxtNombreCompleto.Text}', '{cmbEstado.SelectedValue}', {cmbRol.SelectedValue}, {cmbEmpleado.SelectedValue}";
                DataTable data = datos.EjecutarQuery(srtSql);
                Dgv1.DataSource = null;
                Dgv1.DataSource = data;
            }
        }
    }
}
