using DkSoftware.LojaVirtual.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DkSoftware.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        ProdutosRepository _produtosRepository;
        public int produtosPorPagina = 6;
        
        public ActionResult ListaProduto(int pagina = 1)
        {
            _produtosRepository = new ProdutosRepository();
            var produtos = _produtosRepository.Produtos
                .OrderBy(x => x.Descricao)
                .Skip((pagina - 1) * produtosPorPagina)
                .Take(produtosPorPagina);

            return View(produtos);
        }
    }
}
