using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public VendedorEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendedorEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
