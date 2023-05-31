using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbicacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbicacion
    {
        [OperationContract]
        List<UbicacionDC> ListarUbicacion();
    }
    [DataContract]
    [Serializable]

    public class UbicacionDC
    {
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public String Distrito { get; set; }
    }
}
