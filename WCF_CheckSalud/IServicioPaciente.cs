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
    public interface IServicioPaciente
    {
        [OperationContract]
        PacienteDC Consultar(String strCodigo);
        [OperationContract]
        List<PacienteDC> Listar();
        [OperationContract]
        Boolean Insertar(PacienteDC paciente);
        [OperationContract]
        Boolean Actualizar(PacienteDC paciente);
        [OperationContract]
        Boolean Eliminar(String strCodigo);
    }

    [DataContract]
    [Serializable]

    public class PacienteDC
    {
        [DataMember]
        public String codPaciente { get; set; }
        [DataMember]
        public String nomPaciente { get; set; }
        [DataMember]
        public String apePaciente { get; set; }
        [DataMember]
        public DateTime fechaNacimiento { get; set; }
        [DataMember]
        public String dniPaciente { get; set; }
        [DataMember]
        public Int32 sexo { get; set; }
        [DataMember]
        public String direcPaciente { get; set; }
        [DataMember]
        public Int32 tipoSangre { get; set; }
        [DataMember]
        public byte[] fotoPaciente { get; set; }
        [DataMember]
        public String emailPaciente { get; set; }
        [DataMember]
        public DateTime fechaIngreso { get; set; }
        [DataMember]
        public String numTelefono { get; set; }
        [DataMember]
        public Int16 estado { get; set; }
        [DataMember]
        public Int16 tipoCliente { get; set; }
        [DataMember]
        public String codEmpresa { get; set; }
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
    }
}
