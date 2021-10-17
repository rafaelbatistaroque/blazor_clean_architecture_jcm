using ECatalogo.Business.Contracts;
using ECatalogo.Core.CasosDeUso;
using ECatalogo.Core.Entidades;

namespace ECatalogo.Business.Handlers
{
    public class ExibirProdutoPorIdHandler : IExibirProdutoPorId
    {
        private readonly IProdutoRepository _repositorio;
        public ExibirProdutoPorIdHandler(IProdutoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public Produto Handler(int id)
        {
            return _repositorio.ObterProduto(id);
        }
    }
}
