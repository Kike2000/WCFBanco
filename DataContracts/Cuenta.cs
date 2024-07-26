using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFBanco.DataContracts
{
    [DataContract]
    public class Cuenta
    {
        [DataMember]
        int Id { get; set; }
        [DataMember]
        string NumeroCuenta { get; set; }
        [DataMember]
        decimal Saldo { get; set; }
        [DataMember]
        string NombreTitular { get; set; }
    }
}