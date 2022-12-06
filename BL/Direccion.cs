using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Direccion
    {
        public static ML.Result GetByIdColonia(int IdColonia)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.DAguirreProgramacionNCapasEntities1 context = new DL_EF.DAguirreProgramacionNCapasEntities1())
                {

                    var codigo = context.DireccionGetByIdColonia(IdColonia).ToList();
                    result.Objects = new List<object>();

                    if (codigo != null)
                    {
                        foreach (var obj in codigo)
                        {
                            ML.Direccion direccion = new ML.Direccion();

                            direccion.IdDireccion = obj.IdDireccion;
                            direccion.Calle = obj.Calle;
                            direccion.NumeroInterior = obj.NumeroInterior;
                            direccion.NumeroExterior = obj.NumeroExterior;

                            direccion.Colonia = new ML.Colonia();
                            direccion.Colonia.IdColonia = IdColonia;

                            result.Objects.Add(direccion);

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
