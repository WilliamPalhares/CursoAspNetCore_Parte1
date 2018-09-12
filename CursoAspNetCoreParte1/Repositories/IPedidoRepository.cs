using CursoAspNetCoreParte1.Models;

namespace CursoAspNetCoreParte1.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}