//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Tb_Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Paciente()
        {
            this.Tb_DocumentoPac = new HashSet<Tb_DocumentoPac>();
            this.Tb_Resultados = new HashSet<Tb_Resultados>();
        }
    
        public string codPaciente { get; set; }
        public string nomPaciente { get; set; }
        public string apePaciente { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public string dniPaciente { get; set; }
        public int sexo { get; set; }
        public string direcPaciente { get; set; }
        public string tipoSangre { get; set; }
        public byte[] fotoPaciente { get; set; }
        public string emailPaciente { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public string numTelefono { get; set; }
        public int estado { get; set; }
        public Nullable<int> tipoCliente { get; set; }
        public string codEmpresa { get; set; }
        public Nullable<System.DateTime> Fec_reg { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public string Id_Ubigeo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_DocumentoPac> Tb_DocumentoPac { get; set; }
        public virtual Tb_Empresa Tb_Empresa { get; set; }
        public virtual Tb_Ubicacion Tb_Ubicacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Resultados> Tb_Resultados { get; set; }
    }
}
