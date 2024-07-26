using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFBanco.Interfaces;

namespace WCFBanco
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TransaccionService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TransaccionService.svc o TransaccionService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TransaccionService : ITransaccionService
    {
        public void Depositar(int cuentaId, decimal monto)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public void Retirar(int cuentaId, decimal monto)
        {
            throw new NotImplementedException();
        }

        public void Transferir(int cuentaOrigenId, int cuentaDestinoId, decimal monto)
        {
            throw new NotImplementedException();
        }
    }
}
