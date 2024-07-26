using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFBanco.DataContracts
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        int Id { get; set; }
        [DataMember]
        string Username { get; set; }
        [DataMember]
        string Password { get; set; }
        [DataMember]
        string Nombre { get; set; }

    }
}