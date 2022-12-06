using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void Add()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingresa el Nombre de la Aseguradora para agregar: \n");
            aseguradora.Nombre = Console.ReadLine();

            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el Id del Usuario para agregar: \n");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();


            result = BL.Aseguradora.AddLINQ(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La Aseguradora se registro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La Aseguradora no se pudo registrar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void Delete()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingresa el Id de la Aseguradora que deseas Eliminar: \n");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();


            result = BL.Aseguradora.DeleteLINQ(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La Aseguradora se elimino correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La Aseguradora no se pudo eliminar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void Update()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            

            Console.WriteLine("Ingresa el ID de la Aseguradora que quieres cambiar los datos: \n");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Nuevo Nombre de la Aseguradora: \n");
            aseguradora.Nombre = Console.ReadLine();

            //Console.WriteLine("La Hora de Modificacion es: \n");
            //aseguradora.FechaModificacion = DateTime.Today;

            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el Nuevo ID del cliente: \n");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();


            result = BL.Aseguradora.UpdateLINQ(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La aseguradora se modifico correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La aseguradora no se pudo modificar" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        public static void GetAll()
        {

            ML.Result result = BL.Aseguradora.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Aseguradora aseguradora in result.Objects)
                {

                    Console.WriteLine("El ID de la Aseguradora es:" + aseguradora.IdAseguradora);
                    Console.WriteLine("El Nombre de la Aseguradora es:" + aseguradora.Nombre);
                    Console.WriteLine("La Fecha de Creacion es:" + aseguradora.FechaCreacion);
                    Console.WriteLine("La Fecha de Modificacion es:" + aseguradora.FechaModificacion);
                    Console.WriteLine("El ID del Usuario es:" + aseguradora.Usuario.IdUsuario);
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error: " + result.ErrorMessage);
            }

        }
        public static void GetById()
        {
            Console.WriteLine("Ingresa el ID de la Aseguradora que deseas consultar");
            int IdAseguradora = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Aseguradora.GetByIdLINQ(IdAseguradora);

            if (result.Correct)
            {
                ML.Aseguradora aseguradora = new ML.Aseguradora();

                //unboxing
                aseguradora = (ML.Aseguradora)result.Object;

                Console.WriteLine("El ID de la Aseguradora es:" + aseguradora.IdAseguradora);
                Console.WriteLine("El Nombre de la Aseguradora es:" + aseguradora.Nombre);
                Console.WriteLine("La Fecha de Creacion es:" + aseguradora.FechaCreacion);
                Console.WriteLine("La Fecha de Creacion es:" + aseguradora.FechaModificacion);
                Console.WriteLine("El ID del Usuario es:" + aseguradora.Usuario.IdUsuario);

            }
            else
            {
                Console.WriteLine("Ocurrio un error: " + result.ErrorMessage);
            }
        }
    }
}
