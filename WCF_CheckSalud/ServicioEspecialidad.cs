using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceEspecialidad" en el código y en el archivo de configuración a la vez.
    public class ServicioEspecialidad : IServicioEspecialidad
    {
        public List<EspecialidadDC> ListarEspecialidad()
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                List<EspecialidadDC> objLista = new List<EspecialidadDC>();

                var query = from misCkSalud in MisCkSalud.Tb_Especialidad
                            orderby misCkSalud.codEspecialidad
                            select misCkSalud;

                foreach( var objConsulta in query )
                {
                    EspecialidadDC objEspecialidadDC = new EspecialidadDC();

                    objEspecialidadDC.codEspecialidad = objConsulta.codEspecialidad;
                    objEspecialidadDC.descEspecialidad = objConsulta.descEspecialidad;

                    objLista.Add(objEspecialidadDC);
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
