using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PL
{
    public class Program
    {
        static void Main(string[] args)

        {
            ML.Usuario cb = new ML.Usuario();
            do
            {
                Console.WriteLine("\n *****************************BIENVENIDOS A LA ASEGURADORA DE GASTOS MEDICOS MAYORES*************************** \n\n\n\n");
                Console.WriteLine("\n ********A que tabla desea realizar alguna operacion******** \n");
                Console.WriteLine("\n 1-. Usuario \n");
                Console.WriteLine("\n 2-. Aseguradora \n");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("\n Bienvenidos a la Tabla Usuario que desea realizar \n\n\n 1- Agregar Usuario \n 2-Eliminar Usuario \n 3-Modificar Usuario \n 4-Consultar todos los Datos de la tabla Usuario \n 5-Consultar todos los Datos de un Usuario por medio de su ID");
                        cb.opc = int.Parse(Console.ReadLine());

                        switch (cb.opc)
                        {
                            case 1:
                                PL.Usuario.Add();
                                break;
                            case 2:
                                PL.Usuario.Delete();
                                break;
                            case 3:
                                PL.Usuario.Update();
                                break;
                            case 4:
                                PL.Usuario.GetAll();
                                break;
                            case 5:
                                PL.Usuario.GetById();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n Bienvenidos a la Tabla Aseguradora que desea realizar \n\n\n 1- Agregar Usuario \n 2-Eliminar Usuario \n 3-Modificar \n 4-Consultar todos los Datos \n 5-Consultar todos los Datos por medio del ID");
                        cb.opc = int.Parse(Console.ReadLine());

                        switch (cb.opc)
                        {
                            case 1:
                                PL.Aseguradora.Add();
                                break;
                            case 2:
                                PL.Aseguradora.Delete();
                                break;
                            case 3:
                                PL.Aseguradora.Update();
                                break;
                            case 4:
                                PL.Aseguradora.GetAll();
                                break;
                            case 5:
                                PL.Aseguradora.GetById();
                                break;
                        }
                        break;

                }

                Console.WriteLine("Deseas realizar otra consulta: \n");
                cb.descision = Console.ReadLine();
            } while (cb.descision.Equals("SI") || cb.descision.Equals("si"));

        }


    }
}
