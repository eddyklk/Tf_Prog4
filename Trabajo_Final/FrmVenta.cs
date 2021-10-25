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
    public partial class FrmVenta : Form
    {
        private ClassDatos Datos;
        private DataTable ListProductos;
        
        public int PrecioProd { get; set; }
        public int Existencia { get; set; }
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public int IdEmp { get; set; }
        public decimal Total { get; set; }

        public List<Compra> ListCompra { get; set; }


        public FrmVenta()
        {
            InitializeComponent();
            Datos = new ClassDatos();
            ListProductos = new DataTable();
            ListCompra = new List<Compra>();
            setComboBoxCliente();
            setComboBoxArticulos();
            lFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            btnEliminar.Enabled = false;
        }

        private void setComboBoxCliente()
        {
            string Query = "SELECT IdCli, NomCli + ' ' + ApellidoCli AS NombreCompleto FROM Clientes ";
            try
            {
                DataTable dato = Datos.EjecutarQuery(Query);
                cbCliente.DisplayMember = "NombreCompleto";
                cbCliente.ValueMember   = "IdCli";
                cbCliente.DataSource    = dato;

            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
            }
        }
        private void setComboBoxArticulos()
        {
            string Query = "SELECT IdProd, NomProd, UbicaProd, CostoProd, PrecioProd, CantidadMin, CantidadMax, Existencia, IdTipoProd FROM Productos ";
            try
            {
                ListProductos = Datos.EjecutarQuery(Query);
                cbArticulo.DisplayMember = "NomProd";
                cbArticulo.ValueMember  = "IdProd";
                cbArticulo.DataSource   = ListProductos;
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
            }
        }
        public void AgregarUsuario(string usuario)
        {
            this.Usuario = usuario;
            buscarUsuario();
        }
        private void cbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BuscarPrecioArticulo(Int32.Parse(cbArticulo.SelectedValue.ToString()));
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
            }
        }
        private void BuscarPrecioArticulo(int Id)
        {
            try
            {
                DataRow[] drow = ListProductos.Select($"IdProd = {Id}");
                foreach (DataRow row in drow)
                {
                    this.PrecioProd = Int32.Parse(row["PrecioProd"].ToString());
                    this.Existencia = Int32.Parse(row["Existencia"].ToString());
                }
                tbPrecio.Text       = this.PrecioProd.ToString();
                tbExistencia.Text   = this.Existencia.ToString();
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
            }
        }
        private void nudCantidad_Leave(object sender, EventArgs e)
        {
            try
            {
                if (nudCantidad.Value > 0)
                {
                    tbSubTotal.Text = (this.PrecioProd * nudCantidad.Value).ToString();
                }
                else
                {
                    nudCantidad.Value = 0;
                    tbSubTotal.Text = "0";
                }
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool esta = false;
            try
            {
                foreach (Compra compra in ListCompra)
                {
                    if (compra.IdProd == Int32.Parse(cbArticulo.SelectedValue.ToString()))
                    {
                        esta = true;
                        break;
                    }
                }
                if (nudCantidad.Value > 0)
                {
                    if (!esta)
                    {
                        Compra compra = new Compra();

                        compra.IdProd = Int32.Parse(cbArticulo.SelectedValue.ToString());
                        compra.NomProd = cbArticulo.Text;
                        compra.Precio = Decimal.Parse(tbPrecio.Text);
                        compra.Cantidad = (int)nudCantidad.Value;
                        compra.SubTotal = Decimal.Parse(tbSubTotal.Text);

                        this.ListCompra.Add(compra);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = this.ListCompra;
                        calcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("El item ya existe en el listado! ", "Advertencia");
                    }
                }
                else
                {
                    MessageBox.Show("No a ingresado una cantidad que se desea facturar del item! ","Advertencia");
                }
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
                throw;
            }
        }

        private void buscarUsuario()
        {
            if (!String.IsNullOrEmpty(this.Usuario))
            {
                string strSql = $" SELECT NombreCompleto, IdEmp FROM Usuarios WHERE NomUsuario = '{this.Usuario}'";
                DataTable data = Datos.EjecutarQuery(strSql);
                this.NombreUsuario = (string) data.Rows[0][0];
                this.IdEmp = (int)data.Rows[0][1];

                tbNombreUsuario.Text = this.NombreUsuario;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar los datos ya registrados?","Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.DataSource = null;
                tbSubTotal.Text = "0";
                nudCantidad.Value = 0;
                tbPrecio.Text = "0";
                tbSubTotal.Text = "0";
                tbTotalCompra.Text = "0";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Salir, los datos se perderan?","Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea eliminar el item?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                var item = ListCompra.Single(c => c.IdProd == Int32.Parse( (dataGridView1.Rows[index]).Cells["IdProd"].Value.ToString()) );
                ListCompra.Remove(item);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListCompra;
                btnEliminar.Enabled = false;
                calcularTotal();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            foreach (Compra compra in ListCompra)
            {
                total += compra.SubTotal;
            }

            tbTotalCompra.Text = total.ToString("C2");
            this.Total = total;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea proceder con la facturacion de la compra?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {            
                string strSql = $"EXEC DBO.SP_InsertarEncabezadoFactura {this.IdEmp}, 'FISCAL', {cbCliente.SelectedValue}, {this.Total} ";
                DataTable data = Datos.EjecutarQuery(strSql);
                int NumFact = (int)data.Rows[0][0];

                foreach (Compra compra in ListCompra)
                {
                    strSql = "";
                    strSql = $"EXEC DBO.SP_InsertarDetalleFactura {NumFact}, {compra.IdProd}, {compra.Cantidad}, {compra.SubTotal}";
                    Datos.EjecutarQuery(strSql);
                }
                MessageBox.Show("Factura registrada satisfactoriamente!");
                dataGridView1.DataSource = null;
                ListCompra = new List<Compra>();
                tbSubTotal.Text = "0";
                nudCantidad.Value = 0;
                tbPrecio.Text = "0";
                tbSubTotal.Text = "0";
                tbTotalCompra.Text = "0";

            }
        }
    
    }

    public class Compra
    {
        public int IdProd { get; set; }
        public string NomProd { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }

}
