using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface IClienteCnpjService : IServiceBase<CLIENTE_QUADRO_SOCIETARIO>
    {
        CLIENTE_QUADRO_SOCIETARIO CheckExist(CLIENTE_QUADRO_SOCIETARIO fqs, Int32 idAss);
        List<CLIENTE_QUADRO_SOCIETARIO> GetAllItens(Int32 idAss);
        List<CLIENTE_QUADRO_SOCIETARIO> GetByFornecedor(CLIENTE cliente);

        Int32 Create(CLIENTE_QUADRO_SOCIETARIO fqs, LOG log);
        Int32 Create(CLIENTE_QUADRO_SOCIETARIO fqs);
    }
}