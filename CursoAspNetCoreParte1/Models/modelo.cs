using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CursoAspNetCoreParte1.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    [DataContract]
    public class Produto : BaseModel
    {
        public Produto()
        {

        }

        [DataMember]
        [Required]
        public string Codigo { get; private set; }

        [Required]
        [DataMember]
        public string Nome { get; private set; }

        [Required]
        [DataMember]
        public decimal Preco { get; private set; }

        public Produto(string codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }

    [DataContract]
    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public virtual Pedido Pedido { get; set; }

        [Required]
        [DataMember]
        public string Nome { get; set; } = "";

        [Required]
        [DataMember]
        public string Email { get; set; } = "";

        [Required]
        [DataMember]
        public string Telefone { get; set; } = "";

        [Required]
        [DataMember]
        public string Endereco { get; set; } = "";

        [Required]
        [DataMember]
        public string Complemento { get; set; } = "";

        [Required]
        [DataMember]
        public string Bairro { get; set; } = "";

        [Required]
        [DataMember]
        public string Municipio { get; set; } = "";

        [Required]
        [DataMember]
        public string UF { get; set; } = "";

        [Required]
        public string CEP { get; set; } = "";
    }

    [DataContract]
    public class ItemPedido : BaseModel
    {   
        [Required]
        [DataMember]
        public Pedido Pedido { get; private set; }

        [Required]
        [DataMember]
        public Produto Produto { get; private set; }

        [Required]
        [DataMember]
        public int Quantidade { get; private set; }

        [Required]
        [DataMember]
        public decimal PrecoUnitario { get; private set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade, decimal precoUnitario)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        internal void AtualizaQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
    }

    [DataContract]
    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        [DataMember]
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();

        [Required]
        [DataMember]
        public virtual Cadastro Cadastro { get; private set; }
    }
}
