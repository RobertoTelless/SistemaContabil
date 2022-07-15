using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ModelServices.Interfaces.Repositories;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Data.Entity;
using System.Data;

namespace ModelServices.EntitiesServices
{
    public class ClienteCnpjService : ServiceBase<CLIENTE_QUADRO_SOCIETARIO>, IClienteCnpjService
    {
        private readonly IClienteCnpjRepository _baseRepository;
        private readonly ILogRepository _logRepository;
        protected Db_GEDEntities Db = new Db_GEDEntities();

        public ClienteCnpjService(IClienteCnpjRepository baseRepository, ILogRepository logRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _logRepository = logRepository;
        }

        public CLIENTE_QUADRO_SOCIETARIO CheckExist(CLIENTE_QUADRO_SOCIETARIO fqs, Int32 idAss)
        {
            CLIENTE_QUADRO_SOCIETARIO item = _baseRepository.CheckExist(fqs, idAss);
            return item;
        }

        public List<CLIENTE_QUADRO_SOCIETARIO> GetAllItens(Int32 idAss)
        {
            List<CLIENTE_QUADRO_SOCIETARIO> lista = _baseRepository.GetAllItens(idAss);
            return lista;
        }

        public List<CLIENTE_QUADRO_SOCIETARIO> GetByFornecedor(CLIENTE fornecedor)
        {
            List<CLIENTE_QUADRO_SOCIETARIO> lista = _baseRepository.GetByFornecedor(fornecedor);
            return lista;
        }

        public Int32 Create(CLIENTE_QUADRO_SOCIETARIO fqs, LOG log)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _logRepository.Add(log);
                    _baseRepository.Add(fqs);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Create(CLIENTE_QUADRO_SOCIETARIO fqs)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _baseRepository.Add(fqs);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}