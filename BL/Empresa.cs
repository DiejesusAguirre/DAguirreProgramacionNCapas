using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empresa
    {
        public static ML.Result GetAllEF(ML.Empresa empresa)
        {
            ML.Result result = new ML.Result();

            
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.EmpresaGetAll(empresa.Nombre).ToList();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {
                        foreach (var obj in codigo)
                        {
                            ML.Empresa empresaobj = new ML.Empresa();

                            empresaobj.IdEmpresa = obj.IdEmpresa;
                            empresaobj.Nombre = obj.Nombre;
                            empresaobj.Telefono = obj.Telefono;
                            empresaobj.Email = obj.Email;
                            empresaobj.DireccionWeb = obj.DireccionWeb;
                            empresaobj.Logo = obj.Logo;
                            
                            result.Objects.Add(empresaobj);

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

        
    }
}
