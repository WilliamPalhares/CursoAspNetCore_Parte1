using System.Collections.Generic;

namespace CursoAspNetCoreParte1.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}