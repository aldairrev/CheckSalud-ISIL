using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioConsultas" en el código y en el archivo de configuración a la vez.
    public class ServicioConsultas : IServicioConsultas
    {
        public List<PacienteMedicoDC> ListarPacientesMedicoFechas(String strCod, DateTime fecIni, DateTime fecFin)
        {
            return new List<PacienteMedicoDC>();
        }

        public List<ConsultaPacienteDC> ListarConsultasPacientesFechas(String strCod, DateTime fecIni, DateTime fecFin)
        {
            return new List<ConsultaPacienteDC>();
        }
    }
}
