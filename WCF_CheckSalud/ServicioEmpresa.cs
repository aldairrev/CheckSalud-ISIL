using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEmpresa" en el código y en el archivo de configuración a la vez.
    public class ServicioEmpresa : IServicioEmpresa
    {
        public bool Actualizar(EmpresaDC obj)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_ActualizarEmpresa(obj.codEmpresa, obj.razSocEmp,
                    obj.direccion, obj.telefono, obj.rucEmp,
                    obj.repEmp, obj.Id_Ubigeo, obj.estado);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public EmpresaDC Consultar(string strCodigo)
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                Tb_Empresa objConsulta = (from misCkSalud in MisCkSalud.Tb_Empresa
                                           where misCkSalud.codEmpresa == strCodigo
                                           select misCkSalud).FirstOrDefault();

                EmpresaDC obj = new EmpresaDC();

                if (objConsulta != null)
                {
                    obj.codEmpresa = "";
                }
                obj.codEmpresa = objConsulta.codEmpresa;
                obj.razSocEmp = objConsulta.Raz_soc_emp;
                obj.direccion = objConsulta.Dir_emp;
                obj.telefono = objConsulta.Tel_emp;
                obj.rucEmp = objConsulta.Ruc_emp;
                obj.repEmp = objConsulta.Rep_emp;
                obj.Id_Ubigeo = objConsulta.Id_Ubigeo;
                obj.fechaIngreso = (DateTime) objConsulta.fec_Ingreso;
                obj.estado = (Int16) objConsulta.estado;

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

                MisCkSalud.usp_EliminarEmpresa(strCodigo);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public bool Insertar(EmpresaDC obj)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_InsertarEmpresa(obj.razSocEmp, obj.direccion, obj.telefono, obj.rucEmp, obj.repEmp, obj.Id_Ubigeo, obj.estado);
                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public List<EmpresaDC> Listar()
        {
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();

            try
            {
                List<EmpresaDC> objLista = new List<EmpresaDC>();

                var query = from miCkSalud in MisCkSalud.Tb_Empresa
                            orderby miCkSalud.codEmpresa
                            select miCkSalud;

                foreach (var objConsulta in query)
                {
                    EmpresaDC obj = new EmpresaDC();

                    obj.codEmpresa = objConsulta.codEmpresa;
                    obj.razSocEmp = objConsulta.Raz_soc_emp;
                    obj.direccion = objConsulta.Dir_emp;
                    obj.telefono = objConsulta.Tel_emp;
                    obj.rucEmp = objConsulta.Ruc_emp;
                    obj.repEmp = objConsulta.Rep_emp;
                    obj.Id_Ubigeo = objConsulta.Id_Ubigeo;
                    obj.fechaIngreso = (DateTime)objConsulta.fec_Ingreso;
                    obj.estado = (Int16)objConsulta.estado;

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
