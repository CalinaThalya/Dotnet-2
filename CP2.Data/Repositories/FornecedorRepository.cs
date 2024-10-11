using CP2.Data.AppData;
using CP2.Domain.Entities.CP2.Domain.Entities;
using CP2.Domain.Interfaces;

namespace CP2.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public FornecedorEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
