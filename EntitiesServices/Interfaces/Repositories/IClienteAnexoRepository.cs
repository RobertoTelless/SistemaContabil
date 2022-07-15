using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IClienteAnexoRepository : IRepositoryBase<CLIENTE_ANEXO>
    {
        List<CLIENTE_ANEXO> GetAllItens(Int32 idAss);
        CLIENTE_ANEXO GetItemById(Int32 id);
    }
}
