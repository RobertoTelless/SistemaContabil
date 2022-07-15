using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IMetadadoRepository : IRepositoryBase<METADADO>
    {
        List<METADADO> GetAllItens(Int32 idAss);
        METADADO GetItemById(Int32 id);
    }
}
