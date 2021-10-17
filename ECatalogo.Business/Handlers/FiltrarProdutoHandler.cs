using ECatalogo.Business.Contracts;
using ECatalogo.Core.CasosDeUso;
using ECatalogo.Core.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ECatalogo.Business.Handlers
{
    public class FiltrarProdutoHandler : IFiltrarProduto
    {
        private readonly IProdutoRepository _repositorio;

        public FiltrarProdutoHandler(IProdutoRepository repositorio)
        {
            _repositorio = repositorio;
        }
        public IReadOnlyCollection<Produto> Handler(string filtro = null)
        {
            var lista = _repositorio.ObterProdutos(filtro).ToList();
            return lista.ConvertAll<Produto>(x => x);
        }
    }
}
