using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ML_Prueba;

namespace BL_Prueba
{
    public class Alumno
    {
        public ML_Prueba.Result AddSP(ML_Prueba.Class1 alumno)
        {
            ML_Prueba.Result result = new ML_Prueba.Result();
            try
            {
                using(SqlConnection conn = new SqlConnection(Conexion.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@Curp", SqlDbType.VarChar);
                        collection[0].Value = alumno;
                        cmd.Parameters.Add(collection);

                        cmd.Connection.Open();

                        int rowAfected = cmd.ExecuteNonQuery();

                        if(rowAfected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }
                }
            }
            catch(Exception ex)
            {

            }
            return result;
        }

        public ML_Prueba.Result GetAll()
        {
            ML_Prueba.Result result = new ML_Prueba.Result();
            try
            {
                using(SqlConnection conn = new SqlConnection(Conexion.Conexion.GetConnectionString()))
                {
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "GetAll";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        DataTable tablaalumno = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(tablaalumno);

                        if(tablaalumno.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach(DataRow row in tablaalumno.Rows)
                            {
                                ML_Prueba.Class1 c = new ML_Prueba.Class1();
                                result.Objects.Add(c);
                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch
            {

            }
            return result;
        }
    }
}
