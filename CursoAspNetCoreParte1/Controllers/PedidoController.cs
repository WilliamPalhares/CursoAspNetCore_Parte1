using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CursoAspNetCoreParte1.Repositories;
using CursoAspNetCoreParte1.Models;

namespace CursoAspNetCoreParte1.Controllers
{
    public class PedidoController : Controller
    {
        private IConfiguration _configuration;
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
        }

        public PedidoController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProduto());
        }

        public IActionResult Carrinho()
        {
            Pedido pedido = pedidoRepository.GetPedido(); 
            return View(pedido.Itens);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}