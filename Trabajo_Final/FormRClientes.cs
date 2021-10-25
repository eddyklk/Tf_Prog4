using CargarItemsComboBox;
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
        public FormRClientes()
        {
            InitializeComponent();
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Dgv1.Rows.Add(TxtNom.Text, TxtApe.Text, TxtDirec.Text, CmbCiudad.Text, TxtTel.Text, TxtCel.Text, CmbEstado.Text);
            
        }

        private void FormRClientes_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.cmbllenarciu(CmbCiudad);
          
        }
    }
}
