using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEmpresa" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEmpresa
    {
        [OperationContract]
        EmpresaDC Consultar(String strCodigo);
        [OperationContract]
        List<EmpresaDC> Listar();
        [OperationContract]
        Boolean Insertar(EmpresaDC empresa);
        [OperationContract]
        Boolean Actualizar(EmpresaDC empresa);
        [OperationContract]
        Boolean Eliminar(String strCodigo);
    }

    public class EmpresaDC
    {
        [DataMember]
        public String codEmpresa { get; set; }
        [DataMember]
        public String razSocEmp { get; set; }
        [DataMember]
        public String direccion { get; set; }
        [DataMember]
        public String telefono { get; set; }
        [DataMember]
        public String rucEmp { get; set; }
        [DataMember]
        public String repEmp { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public DateTime fechaIngreso { get; set; }
        [DataMember]
        public Int16 estado { get; set; }
    }
}
