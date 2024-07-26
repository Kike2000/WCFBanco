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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UsuarioService.svc o UsuarioService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsuarioService : IUsuarioService
    {
        public bool AutenticarUsuario(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public Usuario ObtenerUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
