using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioMedico" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioMedico
    {
        [OperationContract]
        MedicoDC ConsultarMedico(String strCodigo);
        [OperationContract]
        List<MedicoDC> ListarMedicos();
        [OperationContract]
        Boolean InsertarMedico(MedicoDC medico);
        [OperationContract]
        Boolean ActualizarMedico(MedicoDC medico);
        [OperationContract]
        Boolean EliminarMedico(String strCodigo);
    }

    [DataContract]
    [Serializable]

    public class MedicoDC
    {
        [DataMember]
        public String codMedico { get; set; }
        [DataMember]
        public String dniMedic { get; set; }
        [DataMember]
        public String nomMedico { get; set; }
        [DataMember]
        public String apeMedico { get; set; }
        [DataMember]
        public String apellNomMedico { get; set; }
        [DataMember]
        public String numColegiatura { get; set; }
        [DataMember]
        public DateTime fechaNacimiento { get; set; }
        [DataMember]
        public String emailMedico { get; set; }        
        [DataMember]
        public String fotoMedico { get; set; }
        [DataMember]
        public String direcMedico { get; set; }
        [DataMember]
        public Int16 estado { get; set; }
        [DataMember]
        public String codEspecialidad { get; set; }
        [DataMember]
        public String Login_Usuario { get; set; }
        [DataMember]
        public DateTime Fec_Reg { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime Fech_Ult_Mod { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public DateTime fec_ingreso { get; set; }
    }
}
