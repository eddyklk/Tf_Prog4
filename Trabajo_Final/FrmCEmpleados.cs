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
    public partial class FrmCEmpleados : Form
    {
        public ClassDatos Datos = new ClassDatos();

        public FrmCEmpleados()
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
            string srtSql = $"Select IdEmp, NomEmp, ApeEmp, DirecEmp, TelEmp, CelEmp, NomTipoEmp, emp.EstadoEmp from Empleados emp inner join Tipo_Empleados tip on emp.IdTipEmp = tip.IdTipoEmp WHERE NomEmp like '%{textBox1.Text}%' OR ApeEmp like '%{textBox1.Text}%'";
            DataTable data = Datos.EjecutarQuery(srtSql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }
    }
}
