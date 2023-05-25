using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioConsultas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioConsultas
    {
        [OperationContract]
        List<PacienteMedicoDC> ListarPacientesMedicoFechas(String strCod, DateTime fecIni, DateTime fecFin);
        [OperationContract]
        List<ConsultaPacienteDC> ListarConsultasPacientesFechas(String strCod, DateTime fecIni, DateTime fecFin);
        /*[OperationContract]
        List<EmpresaPacienteDC> ListarPacientesEmpresa(String strCod);
        [OperationContract]
        List<AnalisisMedicoDC> ListarAnalisisMedico(String strCod);*/
    }
    [DataContract]
    [Serializable]

    public class PacienteMedicoDC
    {
        [DataMember]
        public String codMedico { get; set; }
        [DataMember]
        public String nomPaciente { get; set; }
        [DataMember]
        public String apePaciente { get; set; }
        [DataMember]
        public String fechaNacimiento { get; set; }
        [DataMember]
        public String dniPaciente { get; set; }
        [DataMember]
        public String direcPaciente { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public String emailPaciente { get; set ; }
        [DataMember]
        public String numTelefono { get; set; }
    }

    public class ConsultaPacienteDC
    {
        [DataMember]
        public String codResultado { get; set; }
        [DataMember]
        public String codPaciente { get; set; }
        [DataMember]
        public String Tipo_Examen { get; set; }
        [DataMember]
        public String Fecha_Evaluacion { get; set; }
        [DataMember]
        public String Peso_Paciente_kg { get; set; }
        [DataMember]
        public String Altura_Paciente_m { get; set; }
        [DataMember]
        public String Sangre {  get; set; }
        [DataMember]
        public String Orina { get; set; }
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
        public String descEnfermedad { get; set; }
        [DataMember]
        public String recomendaciones { get; set; }
        
    }/*
    public class EmpresaPacienteDC
    {
        [DataMember]
    }
    public class AnalisisMedicoDC
    {
        [DataMember]
    }*/
}
