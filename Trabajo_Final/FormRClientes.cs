using CargarItemsComboBox;
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
    public partial class FormRClientes : Form
    {
        private ClassDatos datos = new ClassDatos();
        public FormRClientes()
        {
            InitializeComponent();
            TxtId.Text = "0";
            cargarComboBoxEstado();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Dgv1.Rows.Add(TxtNom.Text, TxtApe.Text, TxtDirec.Text, CmbCiudad.Text, TxtTel.Text, TxtCel.Text, CmbEstado.Text);
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Guardar los datos?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string srtSql = $"EXEC DBO.SP_Insertar_Clientes {TxtId.Text}, '{TxtNom.Text}', '{TxtApe.Text}', '{TxtDirec.Text}',1,'{TxtTel.Text}','{TxtCel.Text}', '{CmbEstado.SelectedValue}'";
                DataTable data = datos.EjecutarQuery(srtSql);
                Dgv1.DataSource = null;
                Dgv1.DataSource = data;
            }
        }

        private void FormRClientes_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.cmbllenarciu(CmbCiudad);
          
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtId.Text = "0";
            TxtNom.Clear(); 
            TxtApe.Clear(); 
            TxtDirec.Clear();
            CmbCiudad.SelectedIndex = 0; 
            TxtTel.Clear(); 
            TxtCel.Clear();
            CmbEstado.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Dgv1.DataSource = null;
            Dgv1.DataSource = datos.Consulta("SELECT * FROM Clientes ORDER BY IdCli DESC");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                TxtId.Text = Dgv1.CurrentRow.Cells["IdCli"].Value.ToString();
                TxtNom.Text = Dgv1.CurrentRow.Cells["NomCli"].Value.ToString();
                TxtApe.Text = Dgv1.CurrentRow.Cells["ApellidoCli"].Value.ToString();
                TxtDirec.Text = Dgv1.CurrentRow.Cells["DireccionCli"].Value.ToString();
                CmbCiudad.SelectedValue = Dgv1.CurrentRow.Cells["IdCiu"].Value.ToString();
                TxtTel.Text = Dgv1.CurrentRow.Cells["TeleCli"].Value.ToString();
                TxtCel.Text = Dgv1.CurrentRow.Cells["CelCli"].Value.ToString();
                CmbEstado.SelectedValue = Dgv1.CurrentRow.Cells["EstadoCli"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private void cargarComboBoxEstado()
        {
            List<comboBox> lista = new List<comboBox> {
                new comboBox{ sId = "A", valor = "Activo"},
                new comboBox{ sId = "D", valor = "Desactivado"}
            };

            CmbEstado.DisplayMember = "valor";
            CmbEstado.ValueMember = "sId";
            CmbEstado.DataSource = lista;
        }

    }

}
