using CursoAspNetCoreParte1.Models;

namespace CursoAspNetCoreParte1.Repositories
{
    public interface IItemPedidoRepository
    {
        void UpdateQuantidade(ItemPedido itemPedido);
    }
}