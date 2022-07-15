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
using CrossCutting;

namespace DataServices.Repositories
{
    public class ClasseRepository : RepositoryBase<CLASSE>, IClasseRepository
    {
        public CLASSE CheckExist(CLASSE conta, Int32 idAss)
        {
            IQueryable<CLASSE> query = Db.CLASSE;
            query = query.Where(p => p.CLAS_NM_NOME == conta.CLAS_NM_NOME);
            query = query.Where(p => p.ASSI_CD_ID == idAss);
            return query.FirstOrDefault();
        }

        public CLASSE GetItemById(Int32 id)
        {
            IQueryable<CLASSE> query = Db.CLASSE;
            query = query.Where(p => p.CLAS_CD_ID == id);
            query = query.Include(p => p.METADADO);
            return query.FirstOrDefault();
        }

        public List<CLASSE> GetAllItens(Int32 idAss)
        {
            IQueryable<CLASSE> query = Db.CLASSE.Where(p => p.CLAS_IN_ATIVO == 1);
            query = query.Where(p => p.ASSI_CD_ID == idAss);
            query = query.Include(p => p.METADADO);
            return query.ToList();
        }

        public List<CLASSE> GetAllItensAdm(Int32 idAss)
        {
            IQueryable<CLASSE> query = Db.CLASSE;
            query = query.Where(p => p.ASSI_CD_ID == idAss);
            query = query.Include(p => p.METADADO);
            return query.ToList();
        }

        public List<CLASSE> ExecuteFilter(String nome, Int32 idAss)
        {
            List<CLASSE> lista = new List<CLASSE>();
            IQueryable<CLASSE> query = Db.CLASSE;
            if (!String.IsNullOrEmpty(nome))
            {
                query = query.Where(p => p.CLAS_NM_NOME.Contains(nome));
            }
            if (query != null)
            {
                query = query.Where(p => p.ASSI_CD_ID == idAss);
                query = query.OrderBy(a => a.CLAS_NM_NOME);
                lista = query.ToList<CLASSE>();
            }
            return lista;
        }
    }
}
 