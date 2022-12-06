using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ML;
using System.Data;
using System.Collections.ObjectModel;
using DL_EF;

namespace BL
{
    public class Usuario
    {
        /* public static void Add(ML.Usuario usuarioobj)
         {
             try
             {
                 using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                 {
                     using (SqlCommand cmd = new SqlCommand())
                     {
                         cmd.CommandText = "INSERT INTO Usuario (Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, CorreoElectronico, FechaDeNacimiento) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Sexo, @CorreoElectronico, @FechaDeNacimiento)";
                         cmd.Connection = conn;

                         //Agregar Parametros
                         SqlParameter[] collection = new SqlParameter[6];
                         collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                         collection[0].Value = usuarioobj.Nombre;

                         collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                         collection[1].Value = usuarioobj.ApellidoPaterno;

                         collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                         collection[2].Value = usuarioobj.ApellidoMaterno;

                         collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                         collection[3].Value = usuarioobj.Sexo;

                         collection[4] = new SqlParameter("@CorreoElectronico", System.Data.SqlDbType.VarChar);
                         collection[4].Value = usuarioobj.CorreoElectronico;

                         collection[5] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                         collection[5].Value = usuarioobj.FechaDeNacimiento;

                         //pasarle al command los parametros
                         cmd.Parameters.AddRange(collection);
                         //Abrir la conexion
                         cmd.Connection.Open();
                         //Ejecutando la sentencia
                         int rowsAffected = cmd.ExecuteNonQuery();

                         if (rowsAffected > 0)
                         {
                             Console.WriteLine("El Usuario se Agrego correctamente");
                             cmd.Connection.Close();
                         }
                         else
                         {
                             Console.WriteLine("El registro fallo");
                         }
                     }
                 }
             }
             catch (Exception ex)
             {

             }

         }*/

        //Metodos con unicamente SqlCliente y directamente la consulta, con Result

        /*public static ML.Result Add(ML.Usuario usuarioobj)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "INSERT INTO Usuario (Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, Email, Password, UserName, Telefono, Celular, CURP, IdRol, FechaDeNacimiento) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Sexo, @Email, @Password, @UserName, @Telefono, @Celular, @CURP, @IdRol, @FechaDeNacimiento)";
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[12];
                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = usuarioobj.Nombre;

                        collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[1].Value = usuarioobj.ApellidoPaterno;

                        collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = usuarioobj.ApellidoMaterno;

                        collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                        collection[3].Value = usuarioobj.Sexo;

                        collection[4] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                        collection[4].Value = usuarioobj.FechaDeNacimiento;

                        collection[5] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                        collection[5].Value = usuarioobj.Email;

                        collection[6] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                        collection[6].Value = usuarioobj.Password;

                        collection[7] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                        collection[7].Value = usuarioobj.UserName;

                        collection[8] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                        collection[8].Value = usuarioobj.Telefono;

                        collection[9] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                        collection[9].Value = usuarioobj.Celular;

                        collection[10] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                        collection[10].Value = usuarioobj.CURP;

                        collection[11] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                        collection[11].Value = usuarioobj.IdRol;

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
        }*/

        /*public static ML.Result Delete(ML.Usuario usuarioobj)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "DELETE FROM Usuario WHERE IdUsuario=" + usuarioobj.IdUsuario;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[0].Value = usuarioobj.IdUsuario;

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
        }*/

        /*public static ML.Result Update(ML.Usuario usuarioobj)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        if (usuarioobj.Columna.Equals("Nombre") || usuarioobj.Columna.Equals("nombre"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET Nombre ='" + usuarioobj.Nombre + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.Nombre;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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



                        if (usuarioobj.Columna.Equals("Apellido Paterno") || usuarioobj.Columna.Equals("apellido paterno"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET ApellidoPaterno ='" + usuarioobj.ApellidoPaterno + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.ApellidoPaterno;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("Apellido Materno") || usuarioobj.Columna.Equals("apellido materno"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET ApellidoMaterno ='" + usuarioobj.ApellidoMaterno + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.ApellidoMaterno;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("Sexo") || usuarioobj.Columna.Equals("sexo"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET Sexo ='" + usuarioobj.Sexo + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                            collection[0].Value = usuarioobj.Sexo;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("Fecha de Nacimiento") || usuarioobj.Columna.Equals("fecha de nacimiento"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET FechaDeNacimiento ='" + usuarioobj.FechaDeNacimiento + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                            collection[0].Value = usuarioobj.FechaDeNacimiento;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("Correo") || usuarioobj.Columna.Equals("correo"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET Email ='" + usuarioobj.Email + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.Email;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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




                        if (usuarioobj.Columna.Equals("Password") || usuarioobj.Columna.Equals("password"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET Password ='" + usuarioobj.Password + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.Password;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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



                        if (usuarioobj.Columna.Equals("UserName") || usuarioobj.Columna.Equals("username"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET UserName ='" + usuarioobj.UserName + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.UserName;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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



                        if (usuarioobj.Columna.Equals("Telefono") || usuarioobj.Columna.Equals("telefono"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET Telefono ='" + usuarioobj.Telefono + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.Telefono;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("Celular") || usuarioobj.Columna.Equals("celular"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET Celular ='" + usuarioobj.Celular + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.Celular;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("CURP") || usuarioobj.Columna.Equals("curp"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET CURP ='" + usuarioobj.CURP + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.CURP;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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


                        if (usuarioobj.Columna.Equals("IdRol") || usuarioobj.Columna.Equals("idrol"))
                        {
                            cmd.CommandText = "UPDATE Usuario SET IdRol ='" + usuarioobj.IdRol + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[2];
                            collection[0] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                            collection[0].Value = usuarioobj.IdRol;

                            collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                            collection[1].Value = usuarioobj.IdUsuario;

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



                        if (usuarioobj.Columna.Equals("Todos") || usuarioobj.Columna.Equals("Todos"))
                        {

                            cmd.CommandText = "UPDATE Usuario SET Nombre ='" + usuarioobj.Nombre + "', ApellidoPaterno ='" + usuarioobj.ApellidoPaterno + "', ApellidoMaterno ='" + usuarioobj.ApellidoMaterno + "', Sexo ='" + usuarioobj.Sexo + "', FechaDeNacimiento ='" + usuarioobj.FechaDeNacimiento + "', Email ='" + usuarioobj.Email + "', Password ='" + usuarioobj.Password + "', UserName ='" + usuarioobj.UserName + "', Telefono ='" + usuarioobj.Telefono + "', Celular ='" + usuarioobj.Celular + "', CURP ='" + usuarioobj.CURP + "', IdRol ='" + usuarioobj.IdRol + "' WHERE IdUsuario =" + usuarioobj.IdUsuario;
                            cmd.Connection = conn;

                            //Agregar Parametros
                            SqlParameter[] collection = new SqlParameter[12];
                            collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                            collection[0].Value = usuarioobj.Nombre;

                            collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                            collection[1].Value = usuarioobj.ApellidoPaterno;

                            collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                            collection[2].Value = usuarioobj.ApellidoMaterno;

                            collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                            collection[3].Value = usuarioobj.Sexo;

                            collection[4] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                            collection[4].Value = usuarioobj.FechaDeNacimiento;

                            collection[5] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                            collection[5].Value = usuarioobj.Email;

                            collection[6] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                            collection[6].Value = usuarioobj.Password;

                            collection[7] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                            collection[7].Value = usuarioobj.UserName;

                            collection[8] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                            collection[8].Value = usuarioobj.Telefono;

                            collection[9] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                            collection[9].Value = usuarioobj.Celular;

                            collection[10] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                            collection[10].Value = usuarioobj.CURP;

                            collection[11] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                            collection[11].Value = usuarioobj.IdRol;

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

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }*/

        /*public static ML.Result GetAll(ML.Usuario usuarioobj)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "SELECT Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, FechaDeNacimiento, Email, Password, UserName, Telefono, Celular, CURP, IdRol FROM Usuario";
                        cmd.Connection = conn;

                        cmd.Connection.Open();


                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            result.Correct = true;
                            Console.WriteLine(dr["Nombre"] + ". \n" + dr["ApellidoPaterno"] + ". \n" + dr["ApellidoMaterno"] + ". \n" + dr["Sexo"] + ". \n" + dr["FechaDeNacimiento"] + ". \n" + dr["Email"] + ". \n" + dr["Password"] + ". \n" + dr["UserName"] + ". \n" + dr["Telefono"] + ". \n" + dr["Celular"] + ". \n" + dr["CURP"] + ". \n" + dr["IdRol"] + ". \n");
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
        }*/

        /*public static ML.Result GetById(ML.Usuario usuarioobj)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "SELECT Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, CorreoElectronico, FechaDeNacimiento FROM Usuario WHERE IdUsuario=" + usuarioobj.IdUsuario;
                        cmd.Connection = conn;

                        cmd.Connection.Open();
                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[0].Value = usuarioobj.IdUsuario;

                        //pasarle al command los parametros
                        cmd.Parameters.AddRange(collection);
                        //Abrir la conexion
                        cmd.Connection.Open();
                        //Ejecutando la sentencia

                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            result.Correct = true;
                            Console.WriteLine(dr["Nombre"] + ". \n" + dr["ApellidoPaterno"] + ". \n" + dr["ApellidoMaterno"] + ". \n" + dr["Sexo"] + ". \n" + dr["CorreoElectronico"] + ". \n" + dr["FechaDeNacimiento"]);
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
        }*/

        //Metodos solamente con Store Procedure

        public static ML.Result AddSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "UsuarioAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[12];
                        collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("@Sexo", SqlDbType.Char);
                        collection[3].Value = usuario.Sexo;

                        collection[4] = new SqlParameter("@Email", SqlDbType.VarChar);
                        collection[4].Value = usuario.Email;

                        collection[5] = new SqlParameter("@Password", SqlDbType.VarChar);
                        collection[5].Value = usuario.Password;

                        collection[6] = new SqlParameter("@UserName", SqlDbType.VarChar);
                        collection[6].Value = usuario.UserName;

                        collection[7] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                        collection[7].Value = usuario.Telefono;

                        collection[8] = new SqlParameter("@Celular", SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("@CURP", SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("@IdRol", SqlDbType.Int);
                        collection[10].Value = usuario.ROL.IdRol;

                        collection[11] = new SqlParameter("@FechaDeNacimiento", SqlDbType.VarChar);
                        collection[11].Value = usuario.FechaDeNacimiento;

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

        public static ML.Result DeleteSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UsuarioDelete";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        collection[0].Value = usuario.IdUsuario;

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

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {



                        cmd.CommandText = "UsuarioUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Agregar Parametros
                        SqlParameter[] collection = new SqlParameter[13];
                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                        collection[3].Value = usuario.Sexo;

                        collection[4] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                        collection[4].Value = usuario.Email;

                        collection[5] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                        collection[5].Value = usuario.Password;

                        collection[6] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                        collection[6].Value = usuario.UserName;

                        collection[7] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                        collection[7].Value = usuario.Telefono;

                        collection[8] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                        collection[10].Value = usuario.ROL.IdRol;

                        collection[11] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.VarChar);
                        collection[11].Value = usuario.FechaDeNacimiento;

                        collection[12] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[12].Value = usuario.IdUsuario;

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

        public static ML.Result GetAllSP()
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "UsuarioGetAll";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        //Aqui se almcena la informacion
                        DataTable tableUsuario = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //adapter.SelectCommand = cmd;
                        adapter.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {

                            //Esta sera la Lista
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableUsuario.Rows)
                            {

                                ML.Usuario usuario = new ML.Usuario();
                                usuario.ROL = new ML.Rol();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Sexo = row[4].ToString();
                                usuario.Email = row[5].ToString();
                                usuario.Password = row[6].ToString();
                                usuario.UserName = row[7].ToString();
                                usuario.Telefono = row[8].ToString();
                                usuario.Celular = row[9].ToString();
                                usuario.CURP = row[10].ToString();
                                usuario.ROL.IdRol = int.Parse(row[11].ToString());
                                usuario.FechaDeNacimiento = row[12].ToString() + "\n \n \n";

                                result.Objects.Add(usuario);
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

        public static ML.Result GetByIdSP(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = "UsuarioGetById";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        collection[0].Value = IdUsuario;

                        cmd.Parameters.AddRange(collection);

                        //Aqui se almcena la informacion
                        DataTable tableUsuario = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);



                        adapter.SelectCommand = cmd;
                        adapter.Fill(tableUsuario);


                        if (tableUsuario.Rows.Count > 0)
                        {

                            //Esta sera la Lista
                            //result.Object = new List<object>();
                            DataRow row = tableUsuario.Rows[0];



                            ML.Usuario usuario = new ML.Usuario();
                            usuario.ROL = new ML.Rol();
                            usuario.IdUsuario = int.Parse(row[0].ToString());
                            usuario.Nombre = row[1].ToString();
                            usuario.ApellidoPaterno = row[2].ToString();
                            usuario.ApellidoMaterno = row[3].ToString();
                            usuario.Sexo = row[4].ToString();
                            usuario.Email = row[5].ToString();
                            usuario.Password = row[6].ToString();
                            usuario.UserName = row[7].ToString();
                            usuario.Telefono = row[8].ToString();
                            usuario.Celular = row[9].ToString();
                            usuario.CURP = row[10].ToString();
                            usuario.ROL.IdRol = int.Parse(row[11].ToString());
                            usuario.FechaDeNacimiento = row[12].ToString();

                            //boxing
                            result.Object = usuario;
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
        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Sexo, usuario.Email, usuario.Password, usuario.UserName, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.ROL.IdRol, usuario.FechaDeNacimiento, usuario.Imagen, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);

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

        public static ML.Result DeleteEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.UsuarioDelete(IdUsuario);

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

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.UsuarioUpdate(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Sexo, usuario.Email, usuario.Password, usuario.UserName, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.ROL.IdRol, usuario.FechaDeNacimiento, usuario.Imagen, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia,usuario.IdUsuario);

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

        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            
                if (usuario.Nombre == null)
                {
                    usuario.Nombre = "";
                }
                if (usuario.ApellidoPaterno == null)
                {
                    usuario.ApellidoPaterno = "";
                }
                if (usuario.ROL.IdRol == null)
                {
                    usuario.ROL.IdRol = 0;
                }
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    
                    var codigo = context.UsuarioGetAll(usuario.Nombre, usuario.ApellidoPaterno, usuario.ROL.IdRol).ToList();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {
                        foreach (var obj in codigo)
                        {
                            ML.Usuario usuarioobj = new ML.Usuario();
                            usuarioobj.ROL = new ML.Rol();
                            usuarioobj.Direccion = new ML.Direccion();
                            usuarioobj.Direccion.Colonia = new ML.Colonia();
                            usuarioobj.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuarioobj.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                            usuarioobj.IdUsuario = obj.IdUsuario;
                            usuarioobj.Nombre = obj.Nombre;
                            usuarioobj.ApellidoPaterno = obj.ApellidoPaterno;
                            usuarioobj.ApellidoMaterno = obj.ApellidoMaterno;
                            usuarioobj.Sexo = obj.Sexo;
                            usuarioobj.Email = obj.Email;
                            usuarioobj.Password = obj.Password;
                            usuarioobj.UserName = obj.UserName;
                            usuarioobj.Telefono = obj.Telefono;
                            usuarioobj.Celular = obj.Celular;
                            usuarioobj.CURP = obj.CURP;
                            usuarioobj.ROL.IdRol = (int)obj.IdRol;
                            usuarioobj.ROL.NombreROL = obj.Rol;
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;
                            usuarioobj.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;
                            usuarioobj.Direccion.Colonia.Nombre = obj.NombreColonia;
                            usuarioobj.Direccion.Colonia.CodigoPostal = obj.CodigoPostal;
                            usuarioobj.Direccion.Calle = obj.Calle;
                            usuarioobj.Direccion.NumeroExterior = obj.NumeroExterior;
                            usuarioobj.Direccion.NumeroInterior = obj.NumeroInterior;
                            usuarioobj.FechaDeNacimiento = DateTime.Parse(obj.FechaDeNacimiento.ToString()).ToString("dd-MM-yyyy") + "\n \n \n";
                            usuarioobj.NombreCompleto = usuarioobj.Nombre + " " + usuarioobj.ApellidoPaterno + " " + usuarioobj.ApellidoMaterno;
                            usuarioobj.Imagen = null;
                            usuarioobj.Status = (bool)obj.Status;
                            result.Objects.Add(usuarioobj);

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

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.UsuarioGetById(IdUsuario).FirstOrDefault();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.ROL = new ML.Rol();
                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.Colonia = new ML.Colonia();
                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario.IdUsuario = codigo.IdUsuario;
                        usuario.Nombre = codigo.Nombre;
                        usuario.ApellidoPaterno = codigo.ApellidoPaterno;
                        usuario.ApellidoMaterno = codigo.ApellidoMaterno;
                        usuario.Sexo = codigo.Sexo;
                        usuario.Email = codigo.Email;
                        usuario.Password = codigo.Password;
                        usuario.UserName = codigo.UserName;
                        usuario.Telefono = codigo.Telefono;
                        usuario.Celular = codigo.Celular;
                        usuario.CURP = codigo.CURP;
                        usuario.ROL.IdRol = codigo.IdRol;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = codigo.IdPais;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = codigo.NombrePais;
                        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = codigo.IdEstado;
                        usuario.Direccion.Colonia.Municipio.Estado.Nombre = codigo.NombreEstado;
                        usuario.Direccion.Colonia.Municipio.IdMunicipio = codigo.IdMunicipio;
                        usuario.Direccion.Colonia.Municipio.Nombre = codigo.NombreMunicipio;
                        usuario.Direccion.Colonia.IdColonia = codigo.IdColonia;
                        usuario.Direccion.Colonia.Nombre = codigo.NombreColonia;
                        usuario.Direccion.IdDireccion = codigo.IdDireccion;
                        usuario.Direccion.Calle = codigo.Calle;
                        usuario.Direccion.NumeroExterior = codigo.NumeroExterior;
                        usuario.Direccion.NumeroInterior = codigo.NumeroInterior;

                        usuario.FechaDeNacimiento = DateTime.Parse(codigo.FechaDeNacimiento.ToString()).ToString("dd-MM-yyyy") + "\n \n \n";
                        usuario.Imagen = codigo.Imagen;
                        usuario.Status = (bool)codigo.Status;
                        result.Object = usuario;


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




        //Metodos con LINQ y Store Procedure

        public static ML.Result AddLINQSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Sexo, usuario.Email, usuario.Password, usuario.UserName, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.ROL.IdRol, usuario.FechaDeNacimiento, usuario.Imagen,usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);

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

        public static ML.Result DeleteLINQSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    context.UsuarioDelete(usuario.IdUsuario);

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

        public static ML.Result UpdateLINQSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {

                    context.UsuarioUpdate(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Sexo, usuario.Email, usuario.Password, usuario.UserName, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.ROL.IdRol, usuario.FechaDeNacimiento, usuario.Imagen, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia,usuario.IdUsuario);
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


        // Metodos con solo LINQ

        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    DL_EF.Usuario usuarioDL = new DL_EF.Usuario();
                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.Sexo = usuario.Sexo;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.Password = usuario.Password;
                    usuarioDL.UserName = usuario.UserName;
                    usuarioDL.Telefono = usuario.Telefono;
                    usuarioDL.Celular = usuario.Celular;
                    usuarioDL.CURP = usuario.CURP;
                    usuarioDL.Rol.IdRol = usuario.ROL.IdRol;
                    usuarioDL.FechaDeNacimiento = usuario.FechaDeNacimiento;

                    context.Usuarios.Add(usuarioDL);
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

        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from u in context.Usuarios
                                 where u.IdUsuario == usuario.IdUsuario
                                 select u).First();

                    context.Usuarios.Add(query);
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

        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DAguirreProgramacionNCapasEntities1 context = new DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from u in context.Usuarios
                                 where u.IdUsuario == usuario.IdUsuario
                                 select u).SingleOrDefault();

                    if (query != null)
                    {
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Sexo = usuario.Sexo;
                        query.Email = usuario.Email;
                        query.Password = usuario.Password;
                        query.UserName = usuario.UserName;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.CURP = usuario.CURP;
                        query.Rol.IdRol = usuario.ROL.IdRol;
                        query.FechaDeNacimiento = usuario.FechaDeNacimiento;

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
                    var query = (from u in context.Usuarios
                                 select new
                                 {
                                     IdUsuario = u.IdUsuario,
                                     Nombre = u.Nombre,
                                     ApellidoPaterno = u.ApellidoPaterno,
                                     ApellidoMaterno = u.ApellidoMaterno,
                                     Sexo = u.Sexo,
                                     Email = u.Email,
                                     Password = u.Password,
                                     UserName = u.UserName,
                                     Telefono = u.Telefono,
                                     Celular = u.Celular,
                                     CURP = u.CURP,
                                     IdRol = u.Rol.IdRol,
                                     FechaDeNacimiento = u.FechaDeNacimiento
                                 });

                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.ROL = new ML.Rol();

                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Sexo = obj.Sexo;
                            usuario.Email = obj.Email;
                            usuario.Password = obj.Password;
                            usuario.UserName = obj.UserName;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.ROL.IdRol = obj.IdRol;
                            usuario.FechaDeNacimiento = obj.FechaDeNacimiento;

                            result.Objects.Add(usuario);
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

        public static ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {
                    var query = (from u in context.Usuarios
                                 where u.IdUsuario == IdUsuario
                                 select new
                                 {
                                     u.IdUsuario,
                                     u.Nombre,
                                     u.ApellidoPaterno,
                                     u.ApellidoMaterno,
                                     u.Sexo,
                                     u.Email,
                                     u.Password,
                                     u.UserName,
                                     u.Telefono,
                                     u.Celular,
                                     u.CURP,
                                     u.Rol.IdRol,
                                     u.FechaDeNacimiento
                                 }).FirstOrDefault();
                    if (query != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.ROL = new ML.Rol();

                        usuario.IdUsuario = query.IdUsuario;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.Sexo = query.Sexo;
                        usuario.Email = query.Email;
                        usuario.Password = query.Password;
                        usuario.UserName = query.UserName;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.CURP = query.CURP;
                        usuario.ROL.IdRol = query.IdRol;
                        usuario.FechaDeNacimiento = query.FechaDeNacimiento;

                        result.Object = usuario;

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