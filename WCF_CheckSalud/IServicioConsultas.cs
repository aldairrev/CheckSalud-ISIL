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
        List<PacienteDC> ListarPacientesMedicoFechas(String strCod, DateTime fecIni, DateTime fecFin);
        [OperationContract]
        List<ConsultaDC> ListarConsultasPacientesFechas(String strCod, DateTime fecIni, DateTime fecFin);
        [OperationContract]
        List<PacienteDC> ListarPacientesEmpresa(String strCod);
        [OperationContract]
        List<AnalisisDC> ListarAnalisisMedico(String strCod);
    }


}
