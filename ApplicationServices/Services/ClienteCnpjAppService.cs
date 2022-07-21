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
    public class ClienteCnpjAppService : AppServiceBase<CLIENTE_QUADRO_SOCIETARIO>, IClienteCnpjAppService
    {
        private readonly IClienteCnpjService _baseService;

        public ClienteCnpjAppService(IClienteCnpjService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public CLIENTE_QUADRO_SOCIETARIO CheckExist(CLIENTE_QUADRO_SOCIETARIO fqs, Int32 idAss)
        {
            CLIENTE_QUADRO_SOCIETARIO item = _baseService.CheckExist(fqs, idAss);
            return item;
        }

        public List<CLIENTE_QUADRO_SOCIETARIO> GetAllItens(Int32 idAss)
        {
            List<CLIENTE_QUADRO_SOCIETARIO> lista = _baseService.GetAllItens(idAss);
            return lista;
        }

        public List<CLIENTE_QUADRO_SOCIETARIO> GetByFornecedor(CLIENTE fornecedor)
        {
            List<CLIENTE_QUADRO_SOCIETARIO> lista = _baseService.GetByFornecedor(fornecedor);
            return lista;
        }

        public Int32 ValidateCreate(CLIENTE_QUADRO_SOCIETARIO item, USUARIO usuario)
        {
            try
            {
                // Completa objeto
                item.CLQS_IN_ATIVO = 1;

                // Persiste
                Int32 volta = _baseService.Create(item);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}