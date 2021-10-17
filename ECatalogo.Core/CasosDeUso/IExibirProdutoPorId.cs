using ECatalogo.Core.Entidades;

namespace ECatalogo.Core.CasosDeUso
{
    public interface IExibirProdutoPorId
    {
        Produto Handler(int id);
    }
}
