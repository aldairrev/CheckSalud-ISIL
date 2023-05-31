using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioMedico" en el código y en el archivo de configuración a la vez.
    public class ServicioPaciente : IServicioPaciente
    {
        public bool Actualizar(PacienteDC obj)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_ActualizarEstadoPaciente(obj.codPaciente, obj.nomPaciente,
                    obj.apePaciente, obj.fechaNacimiento, obj.dniPaciente,
                    obj.sexo, obj.direcPaciente, obj.tipoSangre,
                    obj.emailPaciente, obj.fechaIngreso, obj.numTelefono,
                    obj.estado, obj.tipoCliente, obj.codEmpresa, obj.Usu_Ult_Mod, obj.Id_Ubigeo);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public PacienteDC Consultar(string strCodigo)
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                Tb_Paciente objConsulta = (from misCkSalud in MisCkSalud.Tb_Paciente
                                           where misCkSalud.codPaciente == strCodigo
                                           select misCkSalud).FirstOrDefault();

                PacienteDC obj = new PacienteDC();

                if (objConsulta != null)
                {
                    obj.codPaciente = "";
                }
                obj.codPaciente = objConsulta.codPaciente;
                obj.nomPaciente = objConsulta.nomPaciente;
                obj.apePaciente = objConsulta.apePaciente;
                obj.fechaNacimiento = objConsulta.fechaNacimiento;
                obj.dniPaciente = objConsulta.dniPaciente;
                obj.sexo = objConsulta.sexo;
                obj.direcPaciente = objConsulta.direcPaciente;
                obj.tipoSangre = objConsulta.tipoSangre;
                obj.fotoPaciente = objConsulta.fotoPaciente;
                obj.emailPaciente = objConsulta.emailPaciente;
                obj.fechaIngreso = (DateTime)objConsulta.fechaIngreso;
                obj.numTelefono = objConsulta.numTelefono;
                obj.estado = (Int16)objConsulta.estado;
                obj.tipoCliente = (Int16)objConsulta.tipoCliente;
                obj.codEmpresa = objConsulta.codEmpresa;
                obj.Fec_Reg = (DateTime)objConsulta.Fec_reg;
                obj.Usu_Registro = objConsulta.Usu_Registro;
                obj.Fech_Ult_Mod = (DateTime)objConsulta.Fec_Ult_Mod;
                obj.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                obj.Id_Ubigeo = objConsulta.Id_Ubigeo;

                return obj;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Eliminar(string strCodigo)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_EliminarPaciente(strCodigo);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public bool Insertar(PacienteDC obj)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_InsertarEstadoPaciente(obj.nomPaciente,
                    obj.apePaciente, obj.fechaNacimiento, obj.dniPaciente,
                    obj.sexo, obj.direcPaciente, obj.tipoSangre,
                    obj.emailPaciente, obj.fechaIngreso, obj.numTelefono,
                    obj.estado, obj.tipoCliente, obj.codEmpresa,
                    obj.Usu_Registro, obj.Id_Ubigeo);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public List<PacienteDC> Listar()
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                List<PacienteDC> objLista = new List<PacienteDC>();

                var query = from miCkSalud in MisCkSalud.Tb_Paciente
                            orderby miCkSalud.codPaciente
                            select miCkSalud;

                foreach (var objConsulta in query)
                {
                    PacienteDC obj = new PacienteDC();

                    obj.codPaciente = objConsulta.codPaciente;
                    obj.nomPaciente = objConsulta.nomPaciente;
                    obj.apePaciente = objConsulta.apePaciente;
                    obj.fechaNacimiento = objConsulta.fechaNacimiento;
                    obj.dniPaciente = objConsulta.dniPaciente;
                    obj.sexo = objConsulta.sexo;
                    obj.direcPaciente = objConsulta.direcPaciente;
                    obj.tipoSangre = objConsulta.tipoSangre;
                    obj.fotoPaciente = objConsulta.fotoPaciente;
                    obj.emailPaciente = objConsulta.emailPaciente;
                    obj.fechaIngreso = (DateTime)objConsulta.fechaIngreso;
                    obj.numTelefono = objConsulta.numTelefono;
                    obj.estado = (Int16)objConsulta.estado;
                    obj.tipoCliente = (Int16)objConsulta.tipoCliente;
                    obj.codEmpresa = objConsulta.codEmpresa;
                    obj.Fec_Reg = (DateTime)objConsulta.Fec_reg;
                    obj.Usu_Registro = objConsulta.Usu_Registro;
                    obj.Fech_Ult_Mod = Convert.ToDateTime(objConsulta.Fec_Ult_Mod ?? DateTime.Now);
                    obj.Usu_Ult_Mod = objConsulta.Usu_Ult_Mod;
                    obj.Id_Ubigeo = objConsulta.Id_Ubigeo;

                    objLista.Add(obj);
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
