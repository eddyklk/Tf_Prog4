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
    public partial class FormRArticulos : Form
    {
   
        private ClassDatos datos = new ClassDatos();
       // private String Id = null;
        private bool Editar = false;
        

        public FormRArticulos()
        {
            
            InitializeComponent();
            
        }

        private void FormRArticulos_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.llenarItems(CmbTipoProd);
            
        } 

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnRASalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtIdProd.Text = "0";
            TxtNomProd.Clear();
            TxtUbicaProd.Clear();
            TxtCostoProd.Clear();
            TxtPrecioProd.Clear();
            TxtCantMin.Clear();
            TxtCantMax.Clear();
            TxtExistencia.Clear();
            TxtNomProd.Focus();
            dgvRegArt.DataSource = null;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Guardar los datos?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string srtSql = $"EXEC DBO.SP_Insertar_Producto {TxtIdProd.Text}, '{TxtNomProd.Text}', '{TxtUbicaProd.Text}', {TxtCostoProd.Text}, {TxtPrecioProd.Text}, {TxtCantMin.Text}, {TxtCantMax.Text}, {TxtExistencia.Text}, 1";
                DataTable data = datos.EjecutarQuery(srtSql);
                dgvRegArt.DataSource = null;
                dgvRegArt.DataSource = data;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRegArt.SelectedRows.Count > 0)
            {
                Editar = true;
                TxtIdProd.Text     = dgvRegArt.CurrentRow.Cells["IdProd"].Value.ToString();
                TxtNomProd.Text    = dgvRegArt.CurrentRow.Cells["NomProd"].Value.ToString();
                TxtUbicaProd.Text  = dgvRegArt.CurrentRow.Cells["UbicaProd"].Value.ToString();
                TxtCostoProd.Text  = dgvRegArt.CurrentRow.Cells["CostoProd"].Value.ToString();
                TxtPrecioProd.Text = dgvRegArt.CurrentRow.Cells["PrecioProd"].Value.ToString();
                TxtCantMin.Text    = dgvRegArt.CurrentRow.Cells["CantidadMin"].Value.ToString();
                TxtCantMax.Text    = dgvRegArt.CurrentRow.Cells["CantidadMax"].Value.ToString();
                TxtExistencia.Text = dgvRegArt.CurrentRow.Cells["Existencia"].Value.ToString();
                CmbTipoProd.SelectedValue = dgvRegArt.CurrentRow.Cells["IdTipoProd"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        
         private void CmbTipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                     
        }

        private void BtnRAConsultar_Click(object sender, EventArgs e)
        {
            ClassDatos Datos = new ClassDatos();
            dgvRegArt.DataSource = null;
            dgvRegArt.DataSource = Datos.Consulta("Select * from Productos");
        }
    }
}

