using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using EntitiesServices.Work_Classes;
using System.Data.Entity;

namespace DataServices.Repositories
{
    public class MetadadoRepository : RepositoryBase<METADADO>, IMetadadoRepository
    {
        public List<METADADO> GetAllItens(Int32 idAss)
        {
            return Db.METADADO.ToList();
        }

        public METADADO GetItemById(Int32 id)
        {
            IQueryable<METADADO> query = Db.METADADO.Where(p => p.META_CD_ID == id);
            return query.FirstOrDefault();
        }
    }
}
 