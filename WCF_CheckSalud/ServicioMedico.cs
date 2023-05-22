﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioMedico" en el código y en el archivo de configuración a la vez.
    public class ServicioMedico : IServicioMedico
    {
        public bool ActualizarMedico(MedicoDC medico)
        {
            throw new NotImplementedException();
        }

        public MedicoDC ConsultarMedico(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool EliminarMedico(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool InsertarMedico(MedicoDC medico)
        {
            throw new NotImplementedException();
        }

        public List<MedicoDC> ListarMedicos()
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                List<MedicoDC> objLista = new List<MedicoDC>();

                var query = from miCkSalud in MisCkSalud.Tb_Medico
                            orderby miCkSalud.codMedico
                            select miCkSalud;

                foreach ( var objConsulta in query ) { 
                    MedicoDC objMedicoDC = new MedicoDC();
                    objMedicoDC.codMedico = objConsulta.codMedico;
                    objMedicoDC.dniMedic = objConsulta.dniMedic;
                    objMedicoDC.nomMedico = objConsulta.nomMedico;
                    objMedicoDC.apeMedico = objConsulta.apeMedico;
                    objMedicoDC.apellNomMedico = objConsulta.nomMedico + objConsulta.apeMedico;
                    objMedicoDC.numColegiatura = objConsulta.numColegiatura;
                    objMedicoDC.fechaNacimiento = objConsulta.fechaNacimiento;
                    objMedicoDC.emailMedico = objConsulta.emailMedico;
                    objMedicoDC.direcMedico = objConsulta.direcMedico;
                    objMedicoDC.estado = Convert.ToInt16(objConsulta.estado);
                    objMedicoDC.codEspecialidad = objConsulta.codEspecialidad;
                    objMedicoDC.Login_Usuario = objConsulta.Login_Usuario;
                    objMedicoDC.Fec_Reg = Convert.ToDateTime(objConsulta.Fec_Reg);
                    objMedicoDC.Usu_Registro = objConsulta.Usu_Registro;
                    objMedicoDC.Fech_Ult_Mod = Convert.ToDateTime(objConsulta.Fech_Ult_Mod);
                    objMedicoDC.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                    objMedicoDC.Id_Ubigeo = objConsulta.Id_Ubigeo;
                    objMedicoDC.fec_ingreso = Convert.ToDateTime(objConsulta.fec_ingreso);

                    objLista.Add(objMedicoDC);
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
