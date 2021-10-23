using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CargarItemsComboBox
{
    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=Tutorial;Integrated Security=True");
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
                cmd = new SqlCommand("Select NombrePais from Paises", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["NombrePais"].ToString());
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
