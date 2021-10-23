﻿using System;
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

     
        public DataTable Consulta(string tabla)
        {
            string strSql = $"SELECT * FROM {tabla}";
            con.Open();
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

    }
}