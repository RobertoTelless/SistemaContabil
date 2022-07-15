using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IClienteCnpjRepository : IRepositoryBase<CLIENTE_QUADRO_SOCIETARIO>
    {
        CLIENTE_QUADRO_SOCIETARIO CheckExist(CLIENTE_QUADRO_SOCIETARIO fqs, Int32 idAss);
        List<CLIENTE_QUADRO_SOCIETARIO> GetAllItens(Int32 idAss);
        List<CLIENTE_QUADRO_SOCIETARIO> GetByFornecedor(CLIENTE cliente);

    }
}