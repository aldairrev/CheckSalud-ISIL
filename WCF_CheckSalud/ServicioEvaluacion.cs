using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEvaluacion" en el código y en el archivo de configuración a la vez.
    public class ServicioEvaluacion : IServicioEvaluacion
    {
        public Boolean InsertarEvaluacion(EvaluacionDC objEvaluacionDC)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_InsertarEvaluacion(Convert.ToDateTime(objEvaluacionDC.Fec_Eva), objEvaluacionDC.codMedico,
                    objEvaluacionDC.codAuditor, objEvaluacionDC.Estado, objEvaluacionDC.Usu_Registro
                    );

                MisCkSalud.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public List<EvaluacionDC> ListarUltEvaluacion()
        {
            try
            {

                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();
                List<EvaluacionDC> objUltLista = new List<EvaluacionDC>();

                //obtenemos con LINQ el ultimo de la lista
                var query = (from miCkSalud in MisCkSalud.Tb_Evaluacion
                             orderby miCkSalud.codEvaluacion descending
                             select miCkSalud).Take(1);

                foreach (var objConsulta in query)
                {
                    EvaluacionDC objEvaluacionDC = new EvaluacionDC();
                    objEvaluacionDC.codEvaluacion = objConsulta.codEvaluacion;
                    objEvaluacionDC.codMedico = objConsulta.codMedico;
                    objEvaluacionDC.codAuditor = objConsulta.codAuditor;
                    objEvaluacionDC.Usu_Registro = objConsulta.Usu_Registro;

                    objUltLista.Add(objEvaluacionDC);
                }
                return objUltLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
