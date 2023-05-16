using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioResultado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioResultado
    {
        [OperationContract]
        ResultadoDC ConsultarResultado(String strCodigo);
        [OperationContract]
        List<ResultadoDC> ListarResultados(); /*
        [OperationContract]
        Boolean InsertarResultado(ResultadoDC resultado);*/

        
    }
    [DataContract]
    [Serializable]

    public class ResultadoDC
    {
        [DataMember]
        public String codResultado { get; set; }
        [DataMember]
        public String NomApePaciente { get; set; }
        [DataMember]
        public Single peso { get; set; }
        [DataMember]
        public Single altura { get; set; }
        [DataMember]
        public String sangre { get; set; }
        [DataMember]
        public String orina { get; set; }
        [DataMember]
        public String ekg { get; set; }
        [DataMember]
        public String spirometria { get; set; }
        [DataMember]
        public String psicologia { get; set; }
        [DataMember]
        public String rayosX { get; set; }
        [DataMember]
        public String audicion { get; set; }
        [DataMember]
        public String vista { get; set; }
        [DataMember]
        public String codAnalisis { get; set; }
        [DataMember]
        public String codEvaluacion { get; set; }
        [DataMember]
        public String codEnfermedad { get; set; }
        [DataMember]
        public String NomEnfermedad { get; set; }
        [DataMember]
        public String recomendaciones { get; set; }
        [DataMember]
        public String codPaciente { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
    }



}
