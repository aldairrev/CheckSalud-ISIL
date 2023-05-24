using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEvaluacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEvaluacion
    {
        [OperationContract]
        Boolean InsertarEvaluacion(EvaluacionDC objEvaluacionDC);
        [OperationContract]
        EvaluacionDC ConsultarUltEvaluacion();
        [OperationContract]
        List<EvaluacionDC> ListarEvalucion();
    }

    [DataContract]
    [Serializable]
    public class EvaluacionDC
    {
        [DataMember]
        public String codEvaluacion { get; set; }
        [DataMember]
        public String Fec_Eva { get; set; }
        [DataMember]
        public String codMedico { get; set; }
        [DataMember]
        public String codAuditor { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public Int16 Estado { get; set; }
    }
}
