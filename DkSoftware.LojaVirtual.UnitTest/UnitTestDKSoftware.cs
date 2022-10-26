using DkSoftware.LojaVirtual.Web.HtmlHelpers;
using DkSoftware.LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DkSoftware.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestDKSoftware
    {
        [TestMethod]
        public void Take()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;
        }
        
        [TestMethod]
        public void TestarPaginacao()
        {
            //Arrage

            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert

            Assert.AreEqual(
                    @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                  + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                  + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
               );
                
        }

    }
}
