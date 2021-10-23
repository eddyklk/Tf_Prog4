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
        private String Id = null;
        private bool Editar = false;

        public FormRArticulos()
        {
            
            InitializeComponent();
            
        }

        private void FormRArticulos_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnRASalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNomProd.Clear();
            TxtUbicaProd.Clear();
            TxtCostoProd.Clear();
            TxtPrecioProd.Clear();
            TxtCantMin.Clear();
            TxtCantMax.Clear();
            TxtExistencia.Clear();
            TxtNomProd.Focus();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            datos.Insert("Productos", "NomProd,UbicaProd,CostoProd,PrecioProd,CantidadMin,CantidadMax,Existencia", $"'{TxtNomProd.Text}','{TxtUbicaProd.Text}','{TxtCostoProd.Text}','{TxtPrecioProd.Text}','{TxtCantMin.Text}','{TxtCantMax.Text}'");
            MessageBox.Show("Guardado Correctamente");
            dgvRegArt.DataSource = datos.Consulta("Productos");

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRegArt.SelectedRows.Count > 0)
            {
                Editar = true;

                TxtNomProd.Text    = dgvRegArt.CurrentRow.Cells["Productos"].Value.ToString();
                TxtUbicaProd.Text  = dgvRegArt.CurrentRow.Cells["Ubicación"].Value.ToString();
                TxtCostoProd.Text  = dgvRegArt.CurrentRow.Cells["Costo"].Value.ToString();
                TxtPrecioProd.Text = dgvRegArt.CurrentRow.Cells["Precio"].Value.ToString();
                TxtCantMin.Text    = dgvRegArt.CurrentRow.Cells["Cantidad Minima"].Value.ToString();
                TxtCantMax.Text    = dgvRegArt.CurrentRow.Cells["Cantidad Maxima"].Value.ToString();
                TxtExistencia.Text = dgvRegArt.CurrentRow.Cells["Existencia"].Value.ToString();
                CmbTipoProd.SelectedIndex =
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
   
    }
}

