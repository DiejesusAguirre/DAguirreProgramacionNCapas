using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Libro
    {
        public static ML.Result Add()
        {
            ML.Libro libro = new ML.Libro();
            libro.Autor = new ML.Autor();
            libro.Editorial = new ML.Editorial();
            libro.Genero = new ML.Genero();

            Console.WriteLine("Ingresa el nombre del libro:" + libro.Nombre);
            libro.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el ID del Autor:" + libro.Autor.IdAutor);
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de paginas" + libro.NumeroDePaginas);
            libro.NumeroDePaginas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Fecha de Publicacion" + libro.FechaDePublicacion);
            libro.FechaDePublicacion = Console.ReadLine();
            Console.WriteLine("Ingrese el ID del Editorial" + libro.Editorial.IdEditorial);
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Edicion" + libro.Edicion);
            libro.Edicion = Console.ReadLine();
            Console.WriteLine("Ingrese el Id del Genero" + libro.Genero.IdGenero);
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());

            ML.Result result = BL.Libro.Add(libro);
            if(result.Correct)
            {
                Console.Write("Se ha registrado exitosamente");
            }
            else
            {
                Console.Write("No se ha registrado exitosamente" + result.ErrorMessage);
            }
           


            return result;
        }

        public static ML.Result Update()
        {
            ML.Libro libro = new ML.Libro();
            libro.Autor = new ML.Autor();
            libro.Editorial = new ML.Editorial();
            libro.Genero = new ML.Genero();

            Console.WriteLine("Ingresa el nuevo nombre del libro:" + libro.Nombre);
            libro.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo ID del Autor:", libro.Autor.IdAutor);
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo numero de paginas", libro.NumeroDePaginas);
            libro.NumeroDePaginas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva Fecha de Publicacion" + libro.FechaDePublicacion);
            libro.FechaDePublicacion = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo ID del Editorial", libro.Editorial.IdEditorial);
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva Edicion" + libro.Edicion);
            libro.Edicion = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Id del Genero", libro.Genero.IdGenero);
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Id que desee modificar", libro.IdLibro);
            libro.IdLibro = int.Parse(Console.ReadLine());

            ML.Result result = BL.Libro.Update(libro);
            if (result.Correct)
            {
                Console.Write("Se ha Actualizado exitosamente");
            }
            else
            {
                Console.Write("No se ha Aztualizado exitosamente" + result.ErrorMessage);
            }



            return result;
        }

        public static ML.Result Delete()
        {
            ML.Libro libro = new ML.Libro();
            libro.Autor = new ML.Autor();
            libro.Editorial = new ML.Editorial();
            libro.Genero = new ML.Genero();

            Console.WriteLine("Ingrese el Id que desee eliminar", libro.IdLibro);
            libro.IdLibro = int.Parse(Console.ReadLine());

            ML.Result result = BL.Libro.Delete(libro);
            if (result.Correct)
            {
                Console.Write("Se ha Eliminado exitosamente");
            }
            else
            {
                Console.Write("No se ha Eliminado exitosamente" + result.ErrorMessage);
            }



            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = BL.Libro.GetAll();
            

            
            if (result.Correct)
            {
                foreach(ML.Libro libro in result)
                {
                    Console.WriteLine("El nombre del libro es:" + libro.Nombre);
                }

            }
            else
            {

            }
            return result;
        }
    }
}
