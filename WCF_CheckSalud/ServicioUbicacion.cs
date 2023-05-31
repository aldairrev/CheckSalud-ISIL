using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbicacion" en el código y en el archivo de configuración a la vez.
    public class ServicioUbicacion : IServicioUbicacion
    {
        public List<UbicacionDC> ListarUbicacion()
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                List<UbicacionDC> objLista = new List<UbicacionDC>();

                var query = from misCkSalud in MisCkSalud.Tb_Ubicacion
                            orderby misCkSalud.Id_Ubigeo
                            select misCkSalud;

                foreach (var objConsulta in query)
                {
                    UbicacionDC objUbicacionDC = new UbicacionDC();

                    objUbicacionDC.Id_Ubigeo = objConsulta.Id_Ubigeo;
                    objUbicacionDC.Distrito = objConsulta.Distrito;

                    objLista.Add(objUbicacionDC);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
