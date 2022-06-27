using DkSoftware.LojaVirtual.Dominio.Repository;
using System.Linq;
using System.Web.Mvc;

namespace DkSoftware.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepository _produtosRepository;
        // GET: Produto
        public ActionResult Index()
        {
            _produtosRepository = new ProdutosRepository();
            var produtos = _produtosRepository.Produtos.Take(3);

            return View(produtos);
        }
    }
}