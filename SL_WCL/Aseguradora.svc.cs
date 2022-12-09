using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Aseguradora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Aseguradora.svc or Aseguradora.svc.cs at the Solution Explorer and start debugging.
    //, ErrorMessage = result.ErrorMessage, Object = result.Object, Objects = result.Objects
    public class Aseguradora : IAseguradora
    {
        public SL_WCL.Result GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAllEF();
            return new SL_WCL.Result { Correct = result.Correct, Ex = result.Ex, ErrorMessage = result.ErrorMessage, Object = result.Object, Objects = result.Objects };
        }
        public SL_WCL.Result GetById(int idAseguradora)
        {
            ML.Result result = BL.Aseguradora.GetByIdEF(idAseguradora);
            return new SL_WCL.Result { Correct = result.Correct, Ex = result.Ex, ErrorMessage = result.ErrorMessage, Object = result.Object, Objects = result.Objects };
        }
        public SL_WCL.Result Add(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.AddEF(aseguradora);
            return new SL_WCL.Result { Correct = result.Correct, Ex = result.Ex };
        }
        public SL_WCL.Result Update(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);
            return new SL_WCL.Result { Correct = result.Correct, Ex = result.Ex };
        }
        public SL_WCL.Result Delete(int idAseguradora)
        {
            ML.Result result = BL.Aseguradora.DeleteEF(idAseguradora);
            return new SL_WCL.Result { Correct = result.Correct, Ex = result.Ex };
        }
        
    }
}
