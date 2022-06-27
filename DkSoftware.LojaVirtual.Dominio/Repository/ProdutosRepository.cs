using DkSoftware.LojaVirtual.Dominio.Entidade;
using System.Collections.Generic;

namespace DkSoftware.LojaVirtual.Dominio.Repository
{
    public class ProdutosRepository
    {
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<Produto> Produtos
        {            
            get { return _context.Produtos; }
        }
    }
}
