//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDADE()
        {
            this.PRODUTO = new HashSet<PRODUTO>();
        }
    
        public int UNID_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public string UNID_NM_NOME { get; set; }
        public Nullable<int> UNID_IN_ATIVO { get; set; }
        public string UNID_SG_SIGLA { get; set; }
        public Nullable<int> UNID_IN_TIPO_UNIDADE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }
    }
}