using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ApplicationServices.Interfaces;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Text.RegularExpressions;

namespace ApplicationServices.Services
{
    public class ClienteAppService : AppServiceBase<CLIENTE>, IClienteAppService
    {
        private readonly IClienteService _baseService;

        public ClienteAppService(IClienteService baseService): base(baseService)
        {
            _baseService = baseService;
        }

        public List<CLIENTE> GetAllItens(Int32 idAss)
        {
            List<CLIENTE> lista = _baseService.GetAllItens(idAss);
            return lista;
        }

        public List<UF> GetAllUF()
        {
            List<UF> lista = _baseService.GetAllUF();
            return lista;
        }

        public UF GetUFbySigla(String sigla)
        {
            return _baseService.GetUFbySigla(sigla);
        }

        public List<CLIENTE> GetAllItensAdm(Int32 idAss)
        {
            List<CLIENTE> lista = _baseService.GetAllItensAdm(idAss);
            return lista;
        }

        public CLIENTE GetItemById(Int32 id)
        {
            CLIENTE item = _baseService.GetItemById(id);
            return item;
        }

        public CLIENTE GetByEmail(String email)
        {
            CLIENTE item = _baseService.GetByEmail(email);
            return item;
        }

        public CLIENTE CheckExist(CLIENTE conta, Int32 idAss)
        {
            CLIENTE item = _baseService.CheckExist(conta, idAss);
            return item;
        }

        public List<CATEGORIA_CLIENTE> GetAllTipos(Int32 idAss)
        {
            List<CATEGORIA_CLIENTE> lista = _baseService.GetAllTipos(idAss);
            return lista;
        }

        public List<USUARIO> GetAllUsuarios(Int32 idAss)
        {
            List<USUARIO> lista = _baseService.GetAllUsuarios(idAss);
            return lista;
        }

        public CLIENTE_ANEXO GetAnexoById(Int32 id)
        {
            CLIENTE_ANEXO lista = _baseService.GetAnexoById(id);
            return lista;
        }

        public CLIENTE_ANOTACAO GetComentarioById(Int32 id)
        {
            CLIENTE_ANOTACAO lista = _baseService.GetComentarioById(id);
            return lista;
        }

        public Int32 ExecuteFilter(Int32? catId, String razao, String nome, String cpf, String cnpj, String email, String cidade, Int32? uf, Int32 idAss, out List<CLIENTE> objeto)
        {
            try
            {
                objeto = new List<CLIENTE>();
                Int32 volta = 0;

                // Processa filtro
                objeto = _baseService.ExecuteFilter(catId, razao, nome, cpf, cnpj, email, cidade, uf, idAss);
                if (objeto.Count == 0)
                {
                    volta = 1;
                }
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateCreate(CLIENTE item, USUARIO usuario)
        {
            try
            {
                // Verifica existencia prévia
                if (_baseService.CheckExist(item, usuario.ASSI_CD_ID) != null)
                {
                    return 1;
                }

                // Completa objeto
                item.CLIE_IN_ATIVO = 1;
                item.ASSI_CD_ID = usuario.ASSI_CD_ID;

                // Checa endereço
                if (String.IsNullOrEmpty(item.CLIE_NM_ENDERECO))
                {
                    item.CLIE_NM_ENDERECO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_BAIRRO))
                {
                    item.CLIE_NM_BAIRRO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_CIDADE))
                {
                    item.CLIE_NM_CIDADE = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NR_NUMERO))
                {
                    item.CLIE_NR_NUMERO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_COMPLEMENTO))
                {
                    item.CLIE_NM_COMPLEMENTO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NR_CEP))
                {
                    item.CLIE_NR_CEP = "-";
                }
                if (item.UF_CD_ID == null)
                {
                    item.UF_CD_ID = 28;
                }

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "AddCLIE",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CLIENTE>(item)
                };

                // Persiste
                Int32 volta = _baseService.Create(item, log);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(CLIENTE item, CLIENTE itemAntes, USUARIO usuario)
        {
            try
            {
                // Checa endereço
                if (String.IsNullOrEmpty(item.CLIE_NM_ENDERECO))
                {
                    item.CLIE_NM_ENDERECO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_BAIRRO))
                {
                    item.CLIE_NM_BAIRRO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_CIDADE))
                {
                    item.CLIE_NM_CIDADE = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NR_NUMERO))
                {
                    item.CLIE_NR_NUMERO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_COMPLEMENTO))
                {
                    item.CLIE_NM_COMPLEMENTO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NR_CEP))
                {
                    item.CLIE_NR_CEP = "-";
                }
                if (item.UF_CD_ID == null)
                {
                    item.UF_CD_ID = 28;
                }
                item.TIPO_PESSOA = null;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "EditCLIE",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CLIENTE>(item),
                    LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<CLIENTE>(itemAntes)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(CLIENTE item, CLIENTE itemAntes)
        {
            try
            {
                // Checa endereço
                if (String.IsNullOrEmpty(item.CLIE_NM_ENDERECO))
                {
                    item.CLIE_NM_ENDERECO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_BAIRRO))
                {
                    item.CLIE_NM_BAIRRO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_CIDADE))
                {
                    item.CLIE_NM_CIDADE = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NR_NUMERO))
                {
                    item.CLIE_NR_NUMERO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NM_COMPLEMENTO))
                {
                    item.CLIE_NM_COMPLEMENTO = "-";
                }
                if (String.IsNullOrEmpty(item.CLIE_NR_CEP))
                {
                    item.CLIE_NR_CEP = "-";
                }
                if (item.UF_CD_ID == null)
                {
                    item.UF_CD_ID = 28;
                }
                item.TIPO_PESSOA = null;

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateDelete(CLIENTE item, USUARIO usuario)
        {
            try
            {
                // Verifica integridade referencial
                //if (item.DOCUMENTO.Count > 0)
                //{
                //    return 1;
                //}

                // Acerta campos
                item.CLIE_IN_ATIVO = 0;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "DelCLIE",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CLIENTE>(item)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateReativar(CLIENTE item, USUARIO usuario)
        {
            try
            {
                // Verifica integridade referencial

                // Acerta campos
                item.CLIE_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    ASSI_CD_ID = usuario.ASSI_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "ReatCLIE",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CLIENTE>(item)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TIPO_PESSOA> GetAllTiposPessoa()
        {
            List<TIPO_PESSOA> lista = _baseService.GetAllTiposPessoa();
            return lista;
        }

        public CLIENTE_CONTATO GetContatoById(Int32 id)
        {
            CLIENTE_CONTATO lista = _baseService.GetContatoById(id);
            return lista;
        }

        public Int32 ValidateEditContato(CLIENTE_CONTATO item)
        {
            try
            {
                // Persiste
                return _baseService.EditContato(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateCreateContato(CLIENTE_CONTATO item)
        {
            try
            {
                // Persiste
                item.CLCO_IN_ATIVO = 1;
                Int32 volta = _baseService.CreateContato(item);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
