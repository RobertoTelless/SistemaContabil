using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EntitiesServices.Model;
using System.Web;
using EntitiesServices.Attributes;

namespace ERP_Condominios_Solution.ViewModels
{
    public class AssinanteViewModel
    {
        [Key]
        public int ASSI_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo TIPO DE CONDOMÍNIO obrigatorio")]
        public Nullable<int> TICO_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo TIPO DE PESSOA obrigatorio")]
        public Nullable<int> TIPE_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo NOME obrigatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O NOME deve conter no minimo 3 e no máximo 50 caracteres.")]
        public string ASSI_NM_NOME { get; set; }
        public int ASSI_IN_ATIVO { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Deve ser uma data válida")]
        public Nullable<System.DateTime> ASSI_DT_INICIO { get; set; }
        public Nullable<int> ASSI_IN_TIPO { get; set; }
        public Nullable<int> ASSI_IN_STATUS { get; set; }
        [Required(ErrorMessage = "Campo E-Mail obrigatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O E-MAil deve conter no minimo 3 e no máximo 100 caracteres.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Deve ser um e-mail válido")]
        public string ASSI_NM_EMAIL { get; set; }
        [StringLength(50, ErrorMessage = "A RAZÃO SOCIAL deve conter no máximo 50 caracteres.")]
        public string ASSI_NM_RAZAO_SOCIAL { get; set; }
        [StringLength(20, ErrorMessage = "O CNPJ deve conter no máximo 20 caracteres.")]
        [CustomValidationCNPJ(ErrorMessage = "CNPJ inválido")]
        public string ASSI_NR_CNPJ { get; set; }
        [StringLength(20, ErrorMessage = "O CPF deve conter no máximo 20 caracteres.")]
        [CustomValidationCPF(ErrorMessage = "CPF inválido")]
        public string ASSI_NR_CPF { get; set; }
        [StringLength(5000, ErrorMessage = "AS OBSERVAÇÔES deve conter no máximo 5000 caracteres.")]
        public string ASSI_TX_OBSERVACOES { get; set; }
        [Required(ErrorMessage = "Campo ENDEREÇO obrigatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O ENDEREÇO deve conter no minimo 3 e no máximo 50 caracteres.")]
        public string ASSI_NM_ENDERECO { get; set; }
        [Required(ErrorMessage = "Campo NÚMERO obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O NÚMERO deve conter no minimo 1 e no máximo 50 caracteres.")]
        public string ASSI_NR_NUMERO { get; set; }
        [Required(ErrorMessage = "Campo BAIRRO obrigatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O BAIRRO deve conter no minimo 1 e no máximo 20 caracteres.")]
        public string ASSI_NM_BAIRRO { get; set; }
        [Required(ErrorMessage = "Campo CIDADE obrigatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "A CIDADE deve conter no minimo 3 e no máximo 50 caracteres.")]
        public string ASSI_NM_CIDADE { get; set; }
        [Required(ErrorMessage = "Campo UF obrigatorio")]
        public Nullable<int> UF_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo CEP obrigatorio")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "O CEP deve conter no minimo 3 e no máximo 10 caracteres.")]
        public string ASSI_NR_CEP { get; set; }
        public string ASSI_AQ_FOTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        public virtual TIPO_PESSOA TIPO_PESSOA { get; set; }
        public virtual UF UF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCO> BANCO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARGO> CARGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIA_AGENDA> CATEGORIA_AGENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIA_NOTIFICACAO> CATEGORIA_NOTIFICACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIA_PRODUTO> CATEGORIA_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIA_TELEFONE> CATEGORIA_TELEFONE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIA_USUARIO> CATEGORIA_USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTRO_CUSTO> CENTRO_CUSTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFIGURACAO> CONFIGURACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTA_BANCO> CONTA_BANCO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORNECEDOR> FORNECEDOR { get; set; }
        public virtual ICollection<LOG> LOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTICIA> NOTICIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACAO> NOTIFICACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERIODICIDADE_TAREFA> PERIODICIDADE_TAREFA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBCATEGORIA_PRODUTO> SUBCATEGORIA_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBGRUPO> SUBGRUPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA> TAREFA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONE> TELEFONE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMPLATE> TEMPLATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPO_TAREFA> TIPO_TAREFA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIDADE> UNIDADE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

    }
}