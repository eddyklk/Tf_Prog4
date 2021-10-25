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
            

            Dgv1.Rows.Add(TxtNomProd.Text, TxtUbicaProd.Text, TxtCostoProd.Text, TxtPrecioProd.Text, TxtCantMin.Text, TxtCantMax.Text, TxtExistencia.Text, CmbTipoProd.Text);

            //datos.Insert("Productos", "NomProd,UbicaProd,CostoProd,PrecioProd,CantidadMin,CantidadMax,Existencia", $"'{TxtNomProd.Text}','{TxtUbicaProd.Text}','{TxtCostoProd.Text}','{TxtPrecioProd.Text}','{TxtCantMin.Text}','{TxtCantMax.Text}','{TxtExistencia.Text}','{CmbTipoProd.Text}',");
            //MessageBox.Show("Guardado Correctamente");
            //dgvRegArt.DataSource = datos.Consulta("Productos");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                Editar = true;

                TxtNomProd.Text    = Dgv1.CurrentRow.Cells["Productos"].Value.ToString();
                TxtUbicaProd.Text  = Dgv1.CurrentRow.Cells["Ubicación"].Value.ToString();
                TxtCostoProd.Text  = Dgv1.CurrentRow.Cells["Costo"].Value.ToString();
                TxtPrecioProd.Text = Dgv1.CurrentRow.Cells["Precio"].Value.ToString();
                TxtCantMin.Text    = Dgv1.CurrentRow.Cells["Cantidad Minima"].Value.ToString();
                TxtCantMax.Text    = Dgv1.CurrentRow.Cells["Cantidad Maxima"].Value.ToString();
                TxtExistencia.Text = Dgv1.CurrentRow.Cells["Existencia"].Value.ToString();
             
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
            Dgv1.DataSource = Datos.Consulta("Select NomProd ,UbicaProd,CostoProd,PrecioProd,CantidadMin,CantidadMax as 'Cantidad Maxima' ,Existencia from Productos");

            

        }
    }
}

