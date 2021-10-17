using ECatalogo.Business.DTOs;
using System.Collections.Generic;

namespace ECatalogo.Business.Contracts
{
    public interface IProdutoRepository
    {
        ProdutoDTO ObterProduto(int id);
        IReadOnlyCollection<ProdutoDTO> ObterProdutos(string filter = null);
    }
}
