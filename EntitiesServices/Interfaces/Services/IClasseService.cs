using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface IClasseService : IServiceBase<CLASSE>
    {
        Int32 Create(CLASSE perfil, LOG log);
        Int32 Create(CLASSE perfil);
        Int32 Edit(CLASSE perfil, LOG log);
        Int32 Edit(CLASSE perfil);
        Int32 Delete(CLASSE perfil, LOG log);

        CLASSE CheckExist(CLASSE conta, Int32 idAss);
        CLASSE GetItemById(Int32 id);
        List<CLASSE> GetAllItens(Int32 idAss);
        List<CLASSE> GetAllItensAdm(Int32 idAss);
        List<CLASSE> ExecuteFilter(String nome, Int32 idAss);

        List<CATEGORIA_CLIENTE> GetAllTipos(Int32 idAss);
        List<TIPO_PESSOA> GetAllTiposPessoa();
        List<USUARIO> GetAllUsuarios(Int32 idAss);
        List<UF> GetAllUF();
        UF GetUFbySigla(String sigla);

        CLIENTE_CONTATO GetContatoById(Int32 id);
        Int32 EditContato(CLIENTE_CONTATO item);
        Int32 CreateContato(CLIENTE_CONTATO item);
    }
}
