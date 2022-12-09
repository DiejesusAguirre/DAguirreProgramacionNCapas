using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAseguradora" in both code and config file together.
    [ServiceContract]
    public interface IAseguradora
    {
        [OperationContract]
        [ServiceKnownType(typeof(ML.Aseguradora))]
        SL_WCL.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Aseguradora))]
        SL_WCL.Result GetById(int idAseguradora);

        [OperationContract]
        SL_WCL.Result Add(ML.Aseguradora aseguradora);

        [OperationContract]
        SL_WCL.Result Update(ML.Aseguradora aseguradora);

        [OperationContract]
        SL_WCL.Result Delete(int idAseguradora);

        
    }
}
