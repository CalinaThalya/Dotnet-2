using CP2.Domain.Entities;
using CP2.Domain.Entities.CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        FornecedorEntity? DeletarDados(int id);
        FornecedorEntity? ObterPorId(int id);
    }
}
