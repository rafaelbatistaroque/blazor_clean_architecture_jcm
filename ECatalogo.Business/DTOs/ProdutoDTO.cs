using ECatalogo.Core.Entidades;

namespace ECatalogo.Business.DTOs
{
    public class ProdutoDTO
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string Categoria { get; set; }

        public static implicit operator Produto(ProdutoDTO produto)
        {
            return Produto.Criar(
                produto.ProdutoId,
                produto.Nome,
                produto.Descricao,
                produto.Preco,
                produto.ImagemUrl,
                produto.Categoria
                );
        }
    }
}
