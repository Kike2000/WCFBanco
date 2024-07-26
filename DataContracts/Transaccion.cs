using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFBanco.DataContracts
{
    [DataContract]
    public class Transaccion
    {
        [DataMember]
        int Id { get; set; }
        [DataMember]
        int CuentaId { get; set; }
        [DataMember]
        decimal Monto { get; set; }
        [DataMember]
        DateTime Fecha { get; set; }
        [DataMember]
        string Tipo { get; set; }
        //(depósito, retiro, transferencia)
    }
}