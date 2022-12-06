using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class Class1
    {
       
    }
}

/* static void Main(string[] args)
        {

            string DataSource = "LAPTOP-QRQ5EBM5";
            string InitialCatalog = "DAguirreProgramacionNCapas";
            string UserID = "sa";
            string Password = "pass@word1";

            string connectionString = "Data Source =" + DataSource
               + "; Initial Catalog =" + InitialCatalog
                + "; User ID=" + UserID
                + "; Password=" + Password;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("La Base de Datos ha Abrierto Exitosamente!");
                Console.WriteLine("Connection State: " + connection.State.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error con la conexion a la base de datos!\n" + ex.Message);
            }

            Console.ReadLine();

        }*/
