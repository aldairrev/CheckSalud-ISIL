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
    
    public partial class Tb_Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Empresa()
        {
            this.Tb_Paciente = new HashSet<Tb_Paciente>();
        }
    
        public string codEmpresa { get; set; }
        public string Raz_soc_emp { get; set; }
        public string Dir_emp { get; set; }
        public string Tel_emp { get; set; }
        public string Ruc_emp { get; set; }
        public string Rep_emp { get; set; }
        public string Id_Ubigeo { get; set; }
        public Nullable<System.DateTime> fec_Ingreso { get; set; }
        public int estado { get; set; }
    
        public virtual Tb_Ubicacion Tb_Ubicacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Paciente> Tb_Paciente { get; set; }
    }
}
