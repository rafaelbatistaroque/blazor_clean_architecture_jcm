using ECatalogo.Core.Entidades;
using System.Collections.Generic;

namespace ECatalogo.Core.CasosDeUso
{
    public interface IFiltrarProduto
    {
        IReadOnlyCollection<Produto> Handler(string filtro = null);
    }
}
