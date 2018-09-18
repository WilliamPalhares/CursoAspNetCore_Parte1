using CursoAspNetCoreParte1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCoreParte1.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext context) : base(context)
        {
        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = dbSet.Where(ip => ip.Id == itemPedido.Id).SingleOrDefault();

            if (!Equals(itemPedidoDB, null))
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);
                context.SaveChanges();
            }
        }
    }
}
