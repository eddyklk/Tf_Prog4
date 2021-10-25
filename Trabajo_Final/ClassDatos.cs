using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros
{
    public class ClassDatos
    {
        public SqlConnection con = new SqlConnection(@"data source=BARRIOGAMES\SQLBARRIOGAMES; Initial catalog = Tf_Prog4; Integrated Security=true");


        public DataTable Consulta(string strSql)
        {
            //string strSql = $"select * from {tabla}";
            //con.Open();
            DataTable DtTabla = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(strSql, con);
            Da.Fill(DtTabla);
            con.Close();
            return DtTabla;
        }

        /// Este metedo se utiliza para traer todos los datos de una tabla con condicion.

        public DataTable Consulta(string tabla, string condicion)
        {
            string strSql = $"SELECT * FROM {tabla} WHERE {condicion}";
            con.Open();
            DataTable DtTabla = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(strSql, con);
            Da.Fill(DtTabla);
            con.Close();
            return DtTabla;

        }
        public bool Insert(string tabla, string campos, string valores)
        {
            con.Open();
            string sql = $"INSERT INTO {tabla}({campos}) VALUES ({valores})";
            SqlCommand command = new SqlCommand(sql, con);
            if (command.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;

            }

            else
                return false;
        }



        public bool Ingresar(string usuario, string Clave)
        {

            string strSql = " select * from Usuarios where NomUsuario ='" + usuario + "' and Claveusu ='" + Clave + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Editar(string tabla, string campos, string valores)
        {
            con.Open();
            string sql = $"INSERT INTO {tabla}({campos}) VALUES ({valores})";
            SqlCommand command = new SqlCommand(sql, con);
            if (command.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }

            else
                return false;
        }


        //#region EJEMPLO SAID
        public DataTable GetTipoProductos()
        {
            string Query = "EXEC DBO.SP_ObtenerTipoProductos ";
            DataTable DtTabla = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter Da = new SqlDataAdapter(Query, con);
                Da.Fill(DtTabla);
            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                con.Close();
            }                                                
            return DtTabla;
        }
        public DataTable UPDATETipoProductos(int IdTipoProd, string NomTipoProd)
        {
            string Query = $"EXEC DBO.SP_EditarTipoProducto {IdTipoProd}, '{NomTipoProd}'";
            DataTable DtTabla = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter Da = new SqlDataAdapter(Query, con);
                Da.Fill(DtTabla);
            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return DtTabla;
        }

        public DataTable EjecutarQuery(string Query)
        {
            DataTable result = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(Query, con);                
                Adapter.Fill(result);                
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error CD: " + EX.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
       // #endregion


    }
}






