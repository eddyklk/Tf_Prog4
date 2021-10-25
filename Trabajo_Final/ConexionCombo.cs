using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CargarItemsComboBox
{
   public  class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

      public Conexion()
        {
            try
            {

                //cnn = new SqlConnection(@"Data Source=SAID-HOLGUIN;Initial Catalog=Tf_Prog4;Integrated Security=True");
                cnn = new SqlConnection(@"Data Source=BARRIOGAMES\SQLBARRIOGAMES;Initial Catalog=Tf_Prog4;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
        }


        //para llenar el combobox de tipo de producto
        public void llenarItems(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select NomTipoProd from TipoProductos", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["NomTipoProd"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
    }
}
