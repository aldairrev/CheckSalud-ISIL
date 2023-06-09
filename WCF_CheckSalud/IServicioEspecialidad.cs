﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceEspecialidad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEspecialidad
    {
        [OperationContract]
        List<EspecialidadDC> ListarEspecialidad();

        
    }

    [DataContract]
    [Serializable]

        public class EspecialidadDC
        {
            [DataMember]
            public String codEspecialidad { get; set; }
            [DataMember]
            public String descEspecialidad { get; set; }
        }
}
