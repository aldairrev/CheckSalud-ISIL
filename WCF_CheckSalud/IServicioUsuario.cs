using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        Boolean InsertarUsuario(UsuarioDC usuario);
    }

    [DataContract]
    [Serializable]

    public class UsuarioDC
    {
        [DataMember]
        public String Login_Usuario { get; set;}
        [DataMember]
        public String Pass_Usuario { get; set; }
        [DataMember]
        public Int16 Niv_Usuario { get; set; }
        [DataMember]
        public Int16 Est_Usuario { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
    }
}
