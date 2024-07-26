using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFBanco.DataContracts;
using WCFBanco.Interfaces;

namespace WCFBanco
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CuentaService : ICuentaService
    {
        public void ActualizarCuenta(Cuenta cuenta)
        {
            throw new NotImplementedException();
        }

        public void CrearCuenta(Cuenta cuenta)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public void EliminarCuenta(int id)
        {
            throw new NotImplementedException();
        }

        public Cuenta ObtenerCuenta(int id)
        {
            throw new NotImplementedException();
        }
    }
}
