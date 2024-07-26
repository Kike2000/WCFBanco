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
    internal interface IUsuarioService
    {
        [OperationContract]
        Usuario ObtenerUsuario(int id);

        [OperationContract]
        bool AutenticarUsuario(string username, string password);
    }
}
