//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_CheckSalud
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Evaluacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Evaluacion()
        {
            this.Tb_Resultados = new HashSet<Tb_Resultados>();
        }
    
        public string codEvaluacion { get; set; }
        public Nullable<System.DateTime> Fec_Eva { get; set; }
        public Nullable<int> estado { get; set; }
        public string codMedico { get; set; }
        public string codAuditor { get; set; }
        public Nullable<System.DateTime> Fec_reg { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        public virtual Tb_Auditor Tb_Auditor { get; set; }
        public virtual Tb_Medico Tb_Medico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Resultados> Tb_Resultados { get; set; }
    }
}
