using CursoAspNetCoreParte1.Models;
using CursoAspNetCoreParte1.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CursoAspNetCoreParte1
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext context, IProdutoRepository produtoRepository)
        {
            this.context = context;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            context.Database.EnsureCreatedAsync();
            List<Livro> livros = GetLivros();
            produtoRepository.SaveProdutos(livros);
        }

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllTextAsync(@"Data\livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json.Result);
            return livros;
        }
    }

    
}
