using CursoAspNetCoreParte1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCoreParte1.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext context;

        public ProdutoRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (Livro l in livros)
            {
                context.Set<Produto>().Add(new Produto(l.Codigo, l.Nome, l.Preco));
            }

            context.SaveChanges();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
