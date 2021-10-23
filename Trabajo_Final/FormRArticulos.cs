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
        public FormRArticulos()
        {
            InitializeComponent();

        }

        private void FormRArticulos_Load(object sender, EventArgs e)
        {
            ClassDatos Datos = new ClassDatos();
            String strSql = "select * from Productos";
            dgvRegArt.DataSource = Datos.Consulta(strSql);

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
    }
}
