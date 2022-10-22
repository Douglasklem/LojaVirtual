using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DkSoftware.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }
        public int ItensPorPagina{ get; set; }
        public int PaginaAtual { get; set; }
        public int TotalDePagina
        {
            get { return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina); }            
        }        
    }
}