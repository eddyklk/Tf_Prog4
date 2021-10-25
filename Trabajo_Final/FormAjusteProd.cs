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
    public partial class FormAjusteProd : Form
    {
        public FormAjusteProd()
        {
            InitializeComponent();
        }

        private void FormAjusteProd_Load(object sender, EventArgs e)
        {
            //ClassDatos Datos = new ClassDatos();
            //dgv1.DataSource = Datos.Consulta("Select NomProd ,UbicaProd,CostoProd,PrecioProd,CantidadMin,CantidadMax as 'Cantidad Maxima' ,Existencia from Productos");
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgv1.CurrentRow.Index;
            txtDescripcion.Text = dgv1.Rows[fila].Cells[0].Value.ToString();
            TxtExistencia.Text = dgv1.Rows[fila].Cells[6].Value.ToString();
            CmbEntrada.Focus();

        }

        private void Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int existencia, Cantidad, ajustada;
                existencia = int.Parse(TxtExistencia.Text);
                Cantidad = int.Parse(TxtCantidad.Text);

                if (CmbEntrada.Text == "Entrada")
                {
                    ajustada = existencia + Cantidad;
                }
                else
                {
                    ajustada = existencia - Cantidad;
                }
                dgv2.Rows.Add(txtDescripcion.Text, existencia, CmbEntrada.Text, Cantidad, ajustada);

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClassDatos Datos = new ClassDatos();
            dgv1.DataSource = Datos.Consulta("Select NomProd ,UbicaProd,CostoProd,PrecioProd,CantidadMin,CantidadMax as 'Cantidad Maxima' ,Existencia from Productos");
        }
    }   
}
