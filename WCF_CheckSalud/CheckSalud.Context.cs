﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_CheckSalud
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CheckSaludEntities : DbContext
    {
        public CheckSaludEntities()
            : base("name=CheckSaludEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Analisis> Tb_Analisis { get; set; }
        public virtual DbSet<Tb_Auditor> Tb_Auditor { get; set; }
        public virtual DbSet<Tb_DocumentoPac> Tb_DocumentoPac { get; set; }
        public virtual DbSet<Tb_Empresa> Tb_Empresa { get; set; }
        public virtual DbSet<Tb_Enfermedad> Tb_Enfermedad { get; set; }
        public virtual DbSet<Tb_Especialidad> Tb_Especialidad { get; set; }
        public virtual DbSet<Tb_Evaluacion> Tb_Evaluacion { get; set; }
        public virtual DbSet<Tb_Medico> Tb_Medico { get; set; }
        public virtual DbSet<Tb_Paciente> Tb_Paciente { get; set; }
        public virtual DbSet<Tb_Resultados> Tb_Resultados { get; set; }
        public virtual DbSet<Tb_Ubicacion> Tb_Ubicacion { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
    
        public virtual int usp_InsertarResultado(Nullable<decimal> vPeso, Nullable<decimal> vAltura, string vSangre, string vOrina, string vEkg, string vSpiro, string vPsico, string vXray, string vAudi, string vVisi, string vCodAnal, string vCodEva, string vCodEnfe, string vRecom, string vCodPac, string vUsu_Registro)
        {
            var vPesoParameter = vPeso.HasValue ?
                new ObjectParameter("vPeso", vPeso) :
                new ObjectParameter("vPeso", typeof(decimal));
    
            var vAlturaParameter = vAltura.HasValue ?
                new ObjectParameter("vAltura", vAltura) :
                new ObjectParameter("vAltura", typeof(decimal));
    
            var vSangreParameter = vSangre != null ?
                new ObjectParameter("vSangre", vSangre) :
                new ObjectParameter("vSangre", typeof(string));
    
            var vOrinaParameter = vOrina != null ?
                new ObjectParameter("vOrina", vOrina) :
                new ObjectParameter("vOrina", typeof(string));
    
            var vEkgParameter = vEkg != null ?
                new ObjectParameter("vEkg", vEkg) :
                new ObjectParameter("vEkg", typeof(string));
    
            var vSpiroParameter = vSpiro != null ?
                new ObjectParameter("vSpiro", vSpiro) :
                new ObjectParameter("vSpiro", typeof(string));
    
            var vPsicoParameter = vPsico != null ?
                new ObjectParameter("vPsico", vPsico) :
                new ObjectParameter("vPsico", typeof(string));
    
            var vXrayParameter = vXray != null ?
                new ObjectParameter("vXray", vXray) :
                new ObjectParameter("vXray", typeof(string));
    
            var vAudiParameter = vAudi != null ?
                new ObjectParameter("vAudi", vAudi) :
                new ObjectParameter("vAudi", typeof(string));
    
            var vVisiParameter = vVisi != null ?
                new ObjectParameter("vVisi", vVisi) :
                new ObjectParameter("vVisi", typeof(string));
    
            var vCodAnalParameter = vCodAnal != null ?
                new ObjectParameter("vCodAnal", vCodAnal) :
                new ObjectParameter("vCodAnal", typeof(string));
    
            var vCodEvaParameter = vCodEva != null ?
                new ObjectParameter("vCodEva", vCodEva) :
                new ObjectParameter("vCodEva", typeof(string));
    
            var vCodEnfeParameter = vCodEnfe != null ?
                new ObjectParameter("vCodEnfe", vCodEnfe) :
                new ObjectParameter("vCodEnfe", typeof(string));
    
            var vRecomParameter = vRecom != null ?
                new ObjectParameter("vRecom", vRecom) :
                new ObjectParameter("vRecom", typeof(string));
    
            var vCodPacParameter = vCodPac != null ?
                new ObjectParameter("vCodPac", vCodPac) :
                new ObjectParameter("vCodPac", typeof(string));
    
            var vUsu_RegistroParameter = vUsu_Registro != null ?
                new ObjectParameter("vUsu_Registro", vUsu_Registro) :
                new ObjectParameter("vUsu_Registro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarResultado", vPesoParameter, vAlturaParameter, vSangreParameter, vOrinaParameter, vEkgParameter, vSpiroParameter, vPsicoParameter, vXrayParameter, vAudiParameter, vVisiParameter, vCodAnalParameter, vCodEvaParameter, vCodEnfeParameter, vRecomParameter, vCodPacParameter, vUsu_RegistroParameter);
        }
    }
}