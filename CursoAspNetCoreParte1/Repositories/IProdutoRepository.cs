using CursoAspNetCoreParte1.Models;
using System.Collections.Generic;

namespace CursoAspNetCoreParte1.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProduto();
    }
}