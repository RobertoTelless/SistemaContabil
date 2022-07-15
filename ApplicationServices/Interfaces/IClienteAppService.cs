using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ApplicationServices.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<CLIENTE>
    {
        Int32 ValidateCreate(CLIENTE perfil, USUARIO usuario);
        Int32 ValidateEdit(CLIENTE perfil, CLIENTE perfilAntes, USUARIO usuario);
        Int32 ValidateEdit(CLIENTE item, CLIENTE itemAntes);
        Int32 ValidateDelete(CLIENTE perfil, USUARIO usuario);
        Int32 ValidateReativar(CLIENTE perfil, USUARIO usuario);

        List<CLIENTE> GetAllItens(Int32 idAss);
        List<CLIENTE> GetAllItensAdm(Int32 idAss);
        CLIENTE GetItemById(Int32 id);
        CLIENTE GetByEmail(String email);
        CLIENTE CheckExist(CLIENTE conta, Int32 idAss);
        Int32 ExecuteFilter(Int32? catId, String razao, String nome, String cpf, String cnpj, String email, String cidade, Int32? uf, Int32 idAss, out List<CLIENTE> objeto);

        CLIENTE_ANEXO GetAnexoById(Int32 id);
        CLIENTE_ANOTACAO GetComentarioById(Int32 id);

        List<CATEGORIA_CLIENTE> GetAllTipos(Int32 idAss);
        List<TIPO_PESSOA> GetAllTiposPessoa();
        List<USUARIO> GetAllUsuarios(Int32 idAss);
        List<UF> GetAllUF();
        UF GetUFbySigla(String sigla);

        CLIENTE_CONTATO GetContatoById(Int32 id);
        Int32 ValidateEditContato(CLIENTE_CONTATO item);
        Int32 ValidateCreateContato(CLIENTE_CONTATO item);
    }
}
