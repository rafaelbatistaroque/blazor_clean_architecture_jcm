namespace ECatalogo.Core.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; }
        public string Nome { get; }
        public string Descricao { get; }
        public decimal Preco { get; }
        public string ImagemUrl { get; }
        public string Categoria { get; }

        private Produto(int produtoId, string nome, string descricao, decimal preco, string imagemUrl, string categoria)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            ImagemUrl = imagemUrl;
            Categoria = categoria;
        }

        public static Produto Criar(int produtoId, string nome, string descricao, decimal preco, string imagemUrl, string categoria)
        {
            return new Produto(produtoId, nome, descricao, preco, imagemUrl, categoria);
        }
    }
}
