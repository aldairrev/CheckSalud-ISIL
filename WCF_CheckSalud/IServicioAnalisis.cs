using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAnalisis" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAnalisis
    {
        [OperationContract]
        Boolean InsertarAnalisis(AnalisisDC objAnalisisDC);
        [OperationContract]
        List<AnalisisDC> ListarUltAnalisis();
    }

    [DataContract]
    [Serializable]
    public class AnalisisDC
    {
        [DataMember]
        public String codAnalisis { get; set; }
        [DataMember]
        public String descAnalisis { get; set; }
        [DataMember]
        public Double costo { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public Int16 Estado { get; set; }
    }
}
