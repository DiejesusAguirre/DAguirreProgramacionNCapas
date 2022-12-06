using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        //variable del Do
        public string descision { get; set; }

        //Campos de la Tabla
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string CURP { get; set; }
        public string Imagen { get; set; }
        public List<Object> Usuarios { get; set; }

        
        //variable del switch case
        public int opc { get; set; }

        //variable de la columna
        public string Columna { get; set; }

        //Propiedad de navegarion
        public ML.Rol ROL { get; set; }
        public ML.Direccion Direccion { get; set; }
        public bool Status { get; set; }

    }
}
