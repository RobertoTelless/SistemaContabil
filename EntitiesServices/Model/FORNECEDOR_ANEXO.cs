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
    
    public partial class FORNECEDOR_ANEXO
    {
        public int FOAN_CD_ID { get; set; }
        public int FORN_CD_ID { get; set; }
        public string FOAN_NM_TITULO { get; set; }
        public System.DateTime FOAN_DT_ANEXO { get; set; }
        public int FOAN_IN_TIPO { get; set; }
        public string FOAN_AQ_ARQUVO { get; set; }
        public int FOAN_IN_ATIVO { get; set; }
    
        public virtual FORNECEDOR FORNECEDOR { get; set; }
    }
}
