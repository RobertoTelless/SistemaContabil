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
    
    public partial class PRECO_PRODUTO
    {
        public int PRPR_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public Nullable<int> FILI_CD_ID { get; set; }
        public int PROD_CD_ID { get; set; }
        public decimal PRPR_VL_PRECO_BASE { get; set; }
        public Nullable<decimal> PRPR_VL_PRECO_PROMOCAO { get; set; }
        public Nullable<System.DateTime> PRPR_DT_VALIDADE { get; set; }
        public int PRPR_IN_ATIVO { get; set; }
    
        public virtual FILIAL FILIAL { get; set; }
        public virtual PRODUTO PRODUTO { get; set; }
    }
}
