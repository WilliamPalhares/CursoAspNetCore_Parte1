
class Carrinho {    
    ClickIncremento(btn) {
        let data = this.GetData(btn);
        data.Quantidade++;
        this.PostQuantidade(data);
    }

    ClickDecremento(btn) {
        let data = this.GetData(btn);
        data.Quantidade--;
        this.PostQuantidade(data);
    }

    UpdateQuantidade(input) {
        let data = this.GetData(input);
        this.PostQuantidade(data);
    }

    GetData(elemento) {
        var linhaDoItem = $(elemento).parents("[item-id]")
        var itemId = $(linhaDoItem).attr("item-id");
        var novaQtde = $(linhaDoItem).find('input').val();

        var data = {
            Id: itemId,
            Quantidade: novaQtde
        }

        return data;
    }

    PostQuantidade(data) {
        $.ajax({
            url: '/pedido/UpdateQuantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        });
    }
}

var carrinho = new Carrinho();

