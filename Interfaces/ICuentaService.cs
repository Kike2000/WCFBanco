using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFBanco.DataContracts;

namespace WCFBanco.Interfaces
{
    [ServiceContract]
    internal interface ICuentaService
    {
        [OperationContract]
        void CrearCuenta(Cuenta cuenta);

        [OperationContract]
        Cuenta ObtenerCuenta(int id);

        [OperationContract]
        void ActualizarCuenta(Cuenta cuenta);

        [OperationContract]
        void EliminarCuenta(int id);

    }
}
