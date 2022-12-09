using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL_EF;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using ML;
using System.Security.Cryptography;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result Add(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "AseguradoraAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[2];
                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = aseguradora.Nombre;

                        collection[1] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        collection[1].Value = aseguradora.Usuario.IdUsuario;


                        //pasarle al command los parametros
                        cmd.Parameters.AddRange(collection);
                        //Abrir la conexion
                        cmd.Connection.Open();

                        //Ejecutando la sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
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
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Delete(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "AseguradoraDelete";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("@IdAseguradora", SqlDbType.Int);
                        collection[0].Value = aseguradora.IdAseguradora;

                        //pasarle al command los parametros
                        cmd.Parameters.AddRange(collection);
                        //Abrir la conexion
                        cmd.Connection.Open();
                        //Ejecutando la sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Update(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {



                        cmd.CommandText = "AseguradoraUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[3];

                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = aseguradora.Nombre;

                        // collection[1] = new SqlParameter("@FechaModificaicon", SqlDbType.DateTime);
                        // collection[1].Value = aseguradora.FechaModificacion.ToString();

                        collection[1] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        collection[1].Value = aseguradora.Usuario.IdUsuario;

                        collection[2] = new SqlParameter("@IdAseguradora", SqlDbType.Int);
                        collection[2].Value = aseguradora.IdAseguradora;

                        //pasarle al command los parametros
                        cmd.Parameters.AddRange(collection);
                        //Abrir la conexion
                        cmd.Connection.Open();
                        //Ejecutando la sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
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
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "AseguradoraGetAll";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Aqui se almcena la informacion
                        DataTable tableAseguradora = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //adapter.SelectCommand = cmd;
                        adapter.Fill(tableAseguradora);

                        if (tableAseguradora.Rows.Count > 0)
                        {

                            //Esta sera la Lista
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableAseguradora.Rows)
                            {

                                ML.Aseguradora aseguradora = new ML.Aseguradora();
                                aseguradora.Usuario = new ML.Usuario();
                                aseguradora.IdAseguradora = int.Parse(row[0].ToString());
                                aseguradora.Nombre = row[1].ToString();
                                aseguradora.FechaCreacion = (DateTime)row[2];
                                aseguradora.FechaModificacion = (DateTime)row[3];
                                aseguradora.Usuario.IdUsuario = int.Parse(row[4].ToString());

                                result.Objects.Add(aseguradora);
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


            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetById(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "AseguradoraGetById";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("@IdAseguradora", SqlDbType.Int);
                        collection[0].Value = IdAseguradora;

                        cmd.Parameters.AddRange(collection);

                        //Aqui se almcena la informacion
                        DataTable tableAseguradora = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);



                        adapter.SelectCommand = cmd;
                        adapter.Fill(tableAseguradora);


                        if (tableAseguradora.Rows.Count > 0)
                        {

                            //Esta sera la Lista
                            //result.Object = new List<object>();
                            DataRow row = tableAseguradora.Rows[0];



                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.IdAseguradora = int.Parse(row[0].ToString());
                            aseguradora.Nombre = row[1].ToString();
                            aseguradora.FechaCreacion = (DateTime)row[2];
                            aseguradora.FechaModificacion = (DateTime)row[3];
                            aseguradora.Usuario.IdUsuario = int.Parse(row[4].ToString());

                            //boxing
                            result.Object = aseguradora;
                            //}
                            result.Correct = true;

                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }


        //Metodos con Entity Framework
        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.AseguradoraAdd(aseguradora.Nombre, aseguradora.Usuario.IdUsuario);

                    if (codigo > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.AseguradoraDelete(IdAseguradora);

                    if (codigo > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.AseguradoraUpdate(aseguradora.IdAseguradora, aseguradora.Nombre, aseguradora.Usuario.IdUsuario);

                    if (codigo > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.AseguradoraGetAll().ToList();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {
                        foreach (var obj in codigo)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = (DateTime)obj.FechaCreacion;
                            aseguradora.FechaModificacion = (DateTime)obj.FechaModificacion;
                            aseguradora.Usuario.Nombre = obj.NombreUsuario;
                            aseguradora.Usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            aseguradora.Usuario.ApellidoMaterno = obj.ApellidoMaterno;

                            

                            result.Objects.Add(aseguradora);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {

                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.IdAseguradora = codigo.IdAseguradora;
                        aseguradora.Nombre = codigo.Nombre;
                        aseguradora.FechaCreacion = (DateTime)codigo.FechaCreacion;
                        aseguradora.FechaModificacion = (DateTime)codigo.FechaModificacion;
                        aseguradora.Usuario.IdUsuario = codigo.IdUsuario;


                        result.Object = aseguradora;


                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }



        //Metodos con Entity Framework y LINQ y Store Prcedures

        public static ML.Result AddLINQSP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    context.AseguradoraAdd(aseguradora.Nombre, aseguradora.Usuario.IdUsuario);

                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteLINQSP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    context.AseguradoraDelete(aseguradora.IdAseguradora);

                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result UpdateLINQSP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {

                    context.AseguradoraUpdate(aseguradora.IdAseguradora, aseguradora.Nombre, aseguradora.Usuario.IdUsuario);
                    context.SaveChanges();
                    result.Correct = true;

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllLINQSP()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    var codigo = context.AseguradoraGetAll().ToList();
                    result.Objects = new List<object>();
                    if (codigo != null)
                    {
                        foreach (var obj in codigo)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = (DateTime)obj.FechaCreacion;
                            aseguradora.FechaModificacion = (DateTime)obj.FechaModificacion;
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;

                            result.Objects.Add(aseguradora);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro ningun registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdLINQSP(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {

                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.IdAseguradora = codigo.IdAseguradora;
                        aseguradora.Nombre = codigo.Nombre;
                        aseguradora.FechaCreacion = (DateTime)codigo.FechaCreacion;
                        aseguradora.FechaModificacion = (DateTime)codigo.FechaModificacion;
                        aseguradora.Usuario.IdUsuario = codigo.IdUsuario;

                        result.Object = aseguradora;


                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }



        //LINQ

        public static ML.Result AddLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    DL_EF.Aseguradora aseguradoraDL = new DL_EF.Aseguradora();
                    aseguradoraDL.Nombre = aseguradora.Nombre;
                    aseguradoraDL.Usuario.IdUsuario = aseguradora.Usuario.IdUsuario;

                    context.Aseguradoras.Add(aseguradoraDL);
                    var query = context.SaveChanges();

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from a in context.Aseguradoras
                                 where a.IdAseguradora == aseguradora.IdAseguradora
                                 select a).First();

                    context.Aseguradoras.Add(query);
                    context.SaveChanges();

                    result.Correct = true;

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result UpdateLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from a in context.Aseguradoras
                                 where a.IdAseguradora == aseguradora.IdAseguradora
                                 select a).SingleOrDefault();

                    if (query != null)
                    {
                        query.Nombre = aseguradora.Nombre;
                        query.Usuario.IdUsuario = aseguradora.Usuario.IdUsuario;
                        context.SaveChanges();

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se realizo esta operacion";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from a in context.Aseguradoras
                                 select new
                                 {
                                     IdAseguradora = a.IdAseguradora,
                                     Nombre = a.Nombre,
                                     FechaCreacion = a.FechaCreacion,
                                     FechaModificacion = a.FechaModificacion,
                                     IdUsuario = a.Usuario.IdUsuario
                                 });

                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = (DateTime)obj.FechaCreacion;
                            aseguradora.FechaModificacion = (DateTime)obj.FechaModificacion;
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;

                            result.Objects.Add(aseguradora);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No tiene registros";
                    }


                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdLINQ(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from a in context.Aseguradoras
                                 where a.IdAseguradora == IdAseguradora
                                 select new
                                 {
                                     a.IdAseguradora,
                                     a.Nombre,
                                     a.FechaCreacion,
                                     a.FechaModificacion,
                                     a.Usuario.IdUsuario
                                 }).FirstOrDefault();
                    if (query != null)
                    {

                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.IdAseguradora = query.IdAseguradora;
                        aseguradora.Nombre = query.Nombre;
                        aseguradora.FechaCreacion = (DateTime)query.FechaCreacion;
                        aseguradora.FechaModificacion = (DateTime)query.FechaModificacion;
                        aseguradora.Usuario.IdUsuario = query.IdUsuario;

                        result.Object = aseguradora;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No tiene registros";
                    }


                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
