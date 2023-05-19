using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//Agregar
using System.Data.Entity.Core;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioResultado" en el código y en el archivo de configuración a la vez.
    public class ServicioResultado : IServicioResultado
    {
        public ResultadoDC ConsultarResultado(String strCodigo)
        {
            //declaro instancia del modelo BD
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();
            try
            {             
                //Obtenemos el resulato consultado...
                Tb_Resultados objConsulta = (from miCkSalud in MisCkSalud.Tb_Resultados
                                             where miCkSalud.codResultado == strCodigo
                                             select miCkSalud).FirstOrDefault();

                ResultadoDC objResultadoDC = new ResultadoDC();

                //devolvemos datos del cliente ...
                if (objConsulta != null)
                {
                    objResultadoDC.codResultado = String.Empty;
                }
                    objResultadoDC.codResultado = objConsulta.codResultado;
                    objResultadoDC.NomApePaciente = objConsulta.Tb_Paciente.nomPaciente +" , "+
                                                    objConsulta.Tb_Paciente.apePaciente;
                    objResultadoDC.peso = Convert.ToSingle(objConsulta.peso);
                    objResultadoDC.altura = Convert.ToSingle(objConsulta.altura);
                    objResultadoDC.sangre = objConsulta.sangre;
                    objResultadoDC.orina = objConsulta.orina;
                    objResultadoDC.ekg = objConsulta.ekg;
                    objResultadoDC.spirometria = objConsulta.spirometria;
                    objResultadoDC.psicologia = objConsulta.psicologia;
                    objResultadoDC.rayosX = objConsulta.rayosX;
                    objResultadoDC.audicion = objConsulta.audicion;
                    objResultadoDC.vista = objConsulta.vista;
                    objResultadoDC.codAnalisis = objConsulta.codAnalisis;
                    objResultadoDC.codEvaluacion = objConsulta.codEvaluacion;
                    objResultadoDC.NomEnfermedad = objConsulta.Tb_Enfermedad.descEnfermedad;
                    objResultadoDC.recomendaciones = objConsulta.recomendaciones;
                    objResultadoDC.codPaciente = objConsulta.codPaciente;
                    objResultadoDC.Usu_Registro = objConsulta.Usu_Registro;

                
                return objResultadoDC;

            }catch(EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ResultadoDC> ListarResultados()
        {
            //declaro instancia del modelo BD
            CheckSaludEntities MisCkSalud = new CheckSaludEntities();
            try
            {
                List<ResultadoDC> objLista = new List<ResultadoDC>();

                //obtenemos con LINQ la instancia de resultado 
                var query = from miCkSalud in MisCkSalud.Tb_Resultados
                            orderby miCkSalud.codAnalisis
                            select miCkSalud;

                foreach(var objConsulta in query)
                {
                    ResultadoDC objResultadoDC = new ResultadoDC();
                    objResultadoDC.codResultado = objConsulta.codResultado;
                    objResultadoDC.NomApePaciente = objConsulta.Tb_Paciente.nomPaciente + " , " +
                                                    objConsulta.Tb_Paciente.apePaciente;
                    objResultadoDC.peso = Convert.ToSingle(objConsulta.peso);
                    objResultadoDC.altura = Convert.ToSingle(objConsulta.altura);
                    objResultadoDC.sangre = objConsulta.sangre;
                    objResultadoDC.orina = objConsulta.orina;
                    objResultadoDC.ekg = objConsulta.ekg;
                    objResultadoDC.spirometria = objConsulta.spirometria;
                    objResultadoDC.psicologia = objConsulta.psicologia;
                    objResultadoDC.rayosX = objConsulta.rayosX;
                    objResultadoDC.audicion = objConsulta.audicion;
                    objResultadoDC.vista = objConsulta.vista;
                    objResultadoDC.codAnalisis = objConsulta.codAnalisis;
                    objResultadoDC.codEvaluacion = objConsulta.codEvaluacion;
                    objResultadoDC.NomEnfermedad = objConsulta.Tb_Enfermedad.descEnfermedad;
                    objResultadoDC.recomendaciones = objConsulta.recomendaciones;
                    objResultadoDC.codPaciente = objConsulta.codPaciente;
                    objResultadoDC.Usu_Registro = objConsulta.Usu_Registro;

                    //agregamos la instancia a la lista
                    objLista.Add(objResultadoDC);

                }
                return objLista;

            }
            catch(EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public Boolean InsertarResultado(ResultadoDC objResultadoDC)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_InsertarResultado(Convert.ToDecimal(objResultadoDC.peso), Convert.ToDecimal(objResultadoDC.altura), objResultadoDC.sangre,
                    objResultadoDC.orina, objResultadoDC.ekg, objResultadoDC.spirometria, objResultadoDC.psicologia,
                    objResultadoDC.rayosX, objResultadoDC.audicion, objResultadoDC.vista, objResultadoDC.codAnalisis,
                    objResultadoDC.codEvaluacion, objResultadoDC.codEnfermedad, objResultadoDC.recomendaciones,
                    objResultadoDC.codPaciente, objResultadoDC.Usu_Registro);

                MisCkSalud.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean ActualizarResultado(ResultadoDC objResultadoDC)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_ActualizarResultado(objResultadoDC.codResultado, Convert.ToDecimal(objResultadoDC.peso),
                    Convert.ToDecimal(objResultadoDC.altura), objResultadoDC.sangre,
                    objResultadoDC.orina, objResultadoDC.ekg, objResultadoDC.spirometria, objResultadoDC.psicologia,
                    objResultadoDC.rayosX, objResultadoDC.audicion, objResultadoDC.vista, objResultadoDC.codEnfermedad,
                    objResultadoDC.recomendaciones, objResultadoDC.codPaciente,objResultadoDC.Usu_Ult_Mod);

                MisCkSalud.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean EliminarResultado(String strCodigo)
        {
            try
            {
                //declaro instancia del modelo BD
                CheckSaludEntities MisCkSalud = new CheckSaludEntities();

                MisCkSalud.usp_EliminarResultado(strCodigo);
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
