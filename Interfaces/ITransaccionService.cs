using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFBanco.Interfaces
{
    [ServiceContract]
    internal interface ITransaccionService
    {
        [OperationContract]
        void Depositar(int cuentaId, decimal monto);

        [OperationContract]
        void Retirar(int cuentaId, decimal monto);

        [OperationContract]
        void Transferir(int cuentaOrigenId, int cuentaDestinoId, decimal monto);
    }
}
