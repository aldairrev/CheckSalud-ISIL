using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public bool InsertarUsuario(UsuarioDC ObjUsuarioDC)
        {
            try
            {
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_InsertarUsuario(ObjUsuarioDC.Login_Usuario, ObjUsuarioDC.Pass_Usuario, ObjUsuarioDC.Usu_Registro);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
                return false;
            }
        }
    }
}
