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
            ML.Result result = new ML.Result();
            Console.WriteLine("Que desea realizar: \n 1- Add \n 2- Update \n 3- Delete");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {

                case 1:
                    PL.Libro.Add();
                    Console.ReadKey();
                    break;
                case 2:
                    PL.Libro.Update();
                    Console.ReadKey();
                    break;
                case 3:
                    PL.Libro.Delete();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
