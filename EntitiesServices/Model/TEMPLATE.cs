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
    
    public partial class TEMPLATE
    {
        public int TEMP_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public string TEMP_SG_SIGLA { get; set; }
        public string TEMP_NM_NOME { get; set; }
        public string TEMP_TX_CONTEUDO { get; set; }
        public string TEMP_AQ_ARQUIVO { get; set; }
        public int TEMP_IN_ATIVO { get; set; }
        public string TEMP_TX_CONTEUDO_LIMPO { get; set; }
        public string TEMP_TX_CABECALHO { get; set; }
        public string TEMP_TX_CORPO { get; set; }
        public string TEMP_TX_DADOS { get; set; }
        public Nullable<System.DateTime> TEMP_DT_CRIACAO { get; set; }
    
        public virtual ASSINANTE ASSINANTE { get; set; }
    }
}
