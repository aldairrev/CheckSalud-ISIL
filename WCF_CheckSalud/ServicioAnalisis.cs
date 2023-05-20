using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAnalisis" en el código y en el archivo de configuración a la vez.
    public class ServicioAnalisis : IServicioAnalisis
    {
        public Boolean InsertarAnalisis(AnalisisDC objAnalisisDC)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_InsertarAnalisis(objAnalisisDC.descAnalisis, Convert.ToDecimal(objAnalisisDC.costo),
                    objAnalisisDC.Estado, objAnalisisDC.Usu_Registro);

                MisCkSalud.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public List<AnalisisDC> ListarUltAnalisis()
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();
                List<AnalisisDC> objUltLista = new List<AnalisisDC>();

                //obtenemos con LINQ el ultimo de la lista
                var query = (from miCkSalud in MisCkSalud.Tb_Analisis
                             orderby miCkSalud.codAnalisis descending
                             select miCkSalud).Take(1);

                foreach (var objConsulta in query)
                {
                    AnalisisDC objAnalisisDC = new AnalisisDC();
                    objAnalisisDC.codAnalisis = objConsulta.codAnalisis;
                    objAnalisisDC.descAnalisis = objConsulta.descAnalisis;
                    objAnalisisDC.costo = Convert.ToDouble(objConsulta.costo);
                    objAnalisisDC.Usu_Registro = objConsulta.Usu_Registro;
                    objAnalisisDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;

                    objUltLista.Add(objAnalisisDC);
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
