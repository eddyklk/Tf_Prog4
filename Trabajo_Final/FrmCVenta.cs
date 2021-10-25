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
    public partial class FrmCVenta : Form
    {
        private ClassDatos Datos;
        public FrmCVenta()
        {
            InitializeComponent();
            Datos = new ClassDatos();
            setComboBoxCliente();
        }
        private void setComboBoxCliente()
        {
            string Query = "SELECT IdCli, NomCli + ' ' + ApellidoCli AS NombreCompleto FROM Clientes ";
            try
            {
                DataTable dato = Datos.EjecutarQuery(Query);
                cbCliente.DisplayMember = "NombreCompleto";
                cbCliente.ValueMember = "IdCli";
                cbCliente.DataSource = dato;

            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string strSql = $"SELECT NumFact, Cli.NomCli, Cli.ApellidoCli FechaFact, TotalFac, IdEmp FROM Factura AS Fac INNER JOIN Clientes AS Cli ON Cli.IdCli = Fac.IdCli  WHERE Fac.IdCli = {cbCliente.SelectedValue} ORDER BY NumFact DESC";
            DataTable data = Datos.EjecutarQuery(strSql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void btnDetallar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string strSql = $"SELECT NumFac, Pro.NomProd, CantFac, PrecVentaFac FROM Detalle_Factura Det INNER JOIN Productos Pro ON Det.Idpro = Pro.IdProd WHERE Det.NumFac = {dataGridView1.CurrentRow.Cells["NumFact"].Value.ToString()}";
                DataTable data = Datos.EjecutarQuery(strSql);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = data;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
