using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa tu Nombre para agregar: \n");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido Paterno para agregar: \n");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido Materno para agregar: \n");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu Sexo: \n");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa tu Email para agregar: \n");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa tu Password para agregar: \n");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa tu UserName para agregar: \n");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa tu Telefono para agregar: \n");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa tu Celular para agregar: \n");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa tu CURP para agregar: \n");
            usuario.CURP = Console.ReadLine();

            usuario.ROL = new ML.Rol();
            Console.WriteLine("Ingresa tu Id del Rol para agregar: \n");
            usuario.ROL.IdRol = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu Fecha de Nacimiento para agregar: \n");
            usuario.FechaDeNacimiento = Console.ReadLine();

            ML.Result result = new ML.Result();


            result = BL.Usuario.AddSP(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario se registro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El usuario no se pudo registrar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        //Metodo para eliminar
        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el Id del Usuario que desea Eliminar: \n");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();


            result = BL.Usuario.DeleteLINQ(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario se elimino correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El usuario no se pudo eliminar");
                Console.ReadKey();
            }
        }

        //Metodo para modificar
        /*public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa tu Columna que desea modificar: \n");
            usuario.Columna = Console.ReadLine();

            if (usuario.Columna.Equals("Nombre") || usuario.Columna.Equals("nombre"))
            {
                Console.WriteLine("Ingresa tu Nuevo Nombre: \n");
                usuario.Nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Apellido Paterno") || usuario.Columna.Equals("apellido paterno"))
            {
                Console.WriteLine("Ingresa tu nuevo Apellido Paterno: \n");
                usuario.ApellidoPaterno = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Apellido Materno") || usuario.Columna.Equals("apellido materno"))
            {
                Console.WriteLine("Ingresa tu nuevo Apellido Materno: \n");
                usuario.ApellidoMaterno = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Sexo") || usuario.Columna.Equals("sexo"))
            {
                Console.WriteLine("Ingresa tu nuevo Sexo: \n");
                usuario.Sexo = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }



            if (usuario.Columna.Equals("Fecha de Nacimiento") || usuario.Columna.Equals("fecha de nacimiento"))
            {
                Console.WriteLine("Ingresa tu nueva Fecha de Nacimiento: \n");
                usuario.FechaDeNacimiento = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Email") || usuario.Columna.Equals("email"))
            {
                Console.WriteLine("Ingresa tu nuevo Email: \n");
                usuario.Email = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Password") || usuario.Columna.Equals("password"))
            {
                Console.WriteLine("Ingresa tu nueva Password: \n");
                usuario.Password = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }

            if (usuario.Columna.Equals("Username") || usuario.Columna.Equals("username"))
            {
                Console.WriteLine("Ingresa tu nuevo UserName: \n");
                usuario.UserName = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Telefono") || usuario.Columna.Equals("telefono"))
            {
                Console.WriteLine("Ingresa tu nuevo numero de Telefono: \n");
                usuario.Telefono = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("Celular") || usuario.Columna.Equals("celular"))
            {
                Console.WriteLine("Ingresa tu nuevo numero Celular: \n");
                usuario.Celular = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("CURP") || usuario.Columna.Equals("curp"))
            {
                Console.WriteLine("Ingresa tu nuevo CURP: \n");
                usuario.CURP = Console.ReadLine();

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }


            if (usuario.Columna.Equals("IdRol") || usuario.Columna.Equals("idrol"))
            {
                Console.WriteLine("Ingresa tu nuevo Rol: \n");
                usuario.IdRol = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }



            if (usuario.Columna.Equals("Todos") || usuario.Columna.Equals("todos"))
            {
                Console.WriteLine("Ingresa tu Nuevo Nombre: \n");
                usuario.Nombre = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Apellido Paterno: \n");
                usuario.ApellidoPaterno = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Apellido Materno: \n");
                usuario.ApellidoMaterno = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Sexo: \n");
                usuario.Sexo = Console.ReadLine();

                Console.WriteLine("Ingresa tu nueva Fecha de Nacimiento: \n");
                usuario.FechaDeNacimiento = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Email: \n");
                usuario.Email = Console.ReadLine();

                Console.WriteLine("Ingresa tu nueva Password: \n");
                usuario.Password = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo UserName: \n");
                usuario.UserName = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Telefono: \n");
                usuario.Telefono = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Celular: \n");
                usuario.Celular = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo CURP: \n");
                usuario.CURP = Console.ReadLine();

                Console.WriteLine("Ingresa tu nuevo Rol: \n");
                usuario.IdRol = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = new ML.Result();


                result = BL.Usuario.Update(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("El usuario se modifico correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                    Console.ReadKey();
                }
            }
        }*/

        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID del Usuario que quieres cambiar los datos: \n");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu Nuevo Nombre: \n");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo Apellido Paterno: \n");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo Apellido Materno: \n");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo Sexo: \n");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo Email: \n");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa tu nueva Password: \n");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo UserName: \n");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo Telefono: \n");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo Celular: \n");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa tu nuevo CURP: \n");
            usuario.CURP = Console.ReadLine();

            usuario.ROL = new ML.Rol();
            Console.WriteLine("Ingresa tu nuevo Rol: \n");
            usuario.ROL.IdRol = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu nueva Fecha de Nacimiento: \n");
            usuario.FechaDeNacimiento = Console.ReadLine();

            ML.Result result = new ML.Result();


            result = BL.Usuario.UpdateLINQ(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario se modifico correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El usuario no se pudo modificar" + result.ErrorMessage);
                Console.ReadKey();
            }

        }

        public static void GetAll()
        {

            ML.Result result = BL.Usuario.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {

                    Console.WriteLine("El ID del Usuario es:" + usuario.IdUsuario);
                    Console.WriteLine("El Nombre del Usuario es:" + usuario.Nombre);
                    Console.WriteLine("El Apellido Paterno del Usuario es:" + usuario.ApellidoPaterno);
                    Console.WriteLine("El Apellido Materno del Usuario es:" + usuario.ApellidoMaterno);
                    Console.WriteLine("El Sexo del Usuario es:" + usuario.Sexo);
                    Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                    Console.WriteLine("La Password del Usuario es:" + usuario.Password);
                    Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                    Console.WriteLine("El Telefono del Usuario es:" + usuario.Telefono);
                    Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                    Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                    Console.WriteLine("El ID del Rol del Usuario es:" + usuario.ROL.IdRol);
                    Console.WriteLine("El Fecha de Nacimiento del Usuario es:" + usuario.FechaDeNacimiento);
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error: " + result.ErrorMessage);
            }

        }

        public static void GetById()
        {
            Console.WriteLine("Ingresa el ID del Usuario que deseas consultar");
            int IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Usuario.GetByIdLINQ(IdUsuario);

            if (result.Correct)
            {
                ML.Usuario usuario = new ML.Usuario();

                //unboxing
                usuario = (ML.Usuario)result.Object;

                Console.WriteLine("El ID del Usuario es:" + usuario.IdUsuario);
                Console.WriteLine("El Nombre del Usuario es:" + usuario.Nombre);
                Console.WriteLine("El Apellido Paterno del Usuario es:" + usuario.ApellidoPaterno);
                Console.WriteLine("El Apellido Materno del Usuario es:" + usuario.ApellidoMaterno);
                Console.WriteLine("El Sexo del Usuario es:" + usuario.Sexo);
                Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                Console.WriteLine("La Password del Usuario es:" + usuario.Password);
                Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                Console.WriteLine("El Telefono del Usuario es:" + usuario.Telefono);
                Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                Console.WriteLine("El ID del Rol del Usuario es:" + usuario.ROL.IdRol);
                Console.WriteLine("El Fecha de Nacimiento del Usuario es:" + usuario.FechaDeNacimiento);

            }
            else
            {
                Console.WriteLine("Ocurrio un error: " + result.ErrorMessage);
            }
        }
    }
}
