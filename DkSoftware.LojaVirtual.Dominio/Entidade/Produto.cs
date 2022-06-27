using System.ComponentModel.DataAnnotations.Schema;

namespace DkSoftware.LojaVirtual.Dominio.Entidade
{    
    public class Produto
    {
        [Column("PRODUTOID")]
        public int ProdutoId { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }
        [Column("CATEGORIA")]
        public string Categoria { get; set; }
        [Column("PRECO")]
        public int Preco { get; set; }
    }
}
