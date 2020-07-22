//função para atualizar os dados do produto
function atualizarProduto() {

    //criar um objeto JSON para armazenar os dados
    //de cada campo da página de cadastro de produto

    var dados = {
        IdProduto: $("#idproduto_edicao").val(),
        Nome: $("#nome_edicao").val(),
        Preco: $("#preco_edicao").val(),
        Quantidade: $("#quantidade_edicao").val()
    };

    $("#erros").html(""); //limpar as mensagens de erro

    //requisição AJAX para o servidor
    $.ajax({
        type: "POST",
        url: "/Produto/AtualizarProduto",
        data: dados,
        success: function (obj) { //promisse

            //exibir mensagem
            $("#mensagem").html(obj);

            //fechando a janela
            $("#janelaedicao").modal('hide');

            //executando a consulta novamente..
            consultarProdutos();
        },
        error: function (e) { //promisse

            //erro de validação
            if (e.status == 400) {

                //limpar o elemento 'mensagem'
                $("#mensagem").html("");

                //varrer as mensagens de erro
                var conteudo = "";
                $.each(e.responseJSON, function (i, msg) {
                    conteudo += msg + "<br/>";
                });

                $("#erros").html(conteudo);
            }
            //erro interno do servidor
            else if (e.status == 500) {

                $("#mensagem").html(e.responseText);
            }
        }
    });


};

//função para excluir o produto
function excluirProduto() {

    $.ajax({
        type: "POST",
        url: "/Produto/ExcluirProduto",
        data: { id: $("#idproduto_exclusao").html() },
        success: function (msg) {

            //imprimindo mensagem de sucesso..
            $("#mensagem").html(msg);

            //fechar a janela modal de exclusão..
            $("#janelaexclusao").modal("hide");

            //executar a consulta de produtos novamente
            consultarProdutos();
        },
        error: function (e) {
            console.log(e);
        }
    });
};

//função para exibir os dados do produto pelo id
function obterProduto(idProduto) {

    $.ajax({
        type: "POST",
        url: "/Produto/ConsultarProdutoPorId",
        data: { id: idProduto },
        success: function (obj) {

            $("#idproduto_edicao").val(obj.IdProduto);
            $("#nome_edicao").val(obj.Nome);
            $("#preco_edicao").val(obj.Preco);
            $("#quantidade_edicao").val(obj.Quantidade);

            $("#idproduto_exclusao").html(obj.IdProduto);
            $("#nome_exclusao").html(obj.Nome);
            $("#preco_exclusao").html(obj.Preco);
            $("#quantidade_exclusao").html(obj.Quantidade);
            $("#total_exclusao").html(obj.Total);
        },
        error: function (e) {
            console.log(e);
        }
    })
}

//função para executar a consulta de produtos
function consultarProdutos() {

    //requisição AJAX ao controller:
    $.ajax({
        type: "POST",
        url: "/Produto/ConsultarProdutos",
        data: {}, //vazio
        success: function (lista) {

            var conteudo = "";
            $.each(lista, function (i, item) {
                conteudo += "<tr>";
                conteudo += "<td>" + item.IdProduto + "</td>";
                conteudo += "<td>" + item.Nome + "</td>";
                conteudo += "<td>" + item.Preco + "</td>";
                conteudo += "<td>" + item.Quantidade + "</td>";
                conteudo += "<td>" + item.Total + "</td>";
                conteudo += "<td>";
                conteudo += "<button onclick='obterProduto(" +
                    item.IdProduto + ")' class='btn btn-primary" +
                    " btn-sm' data-target='#janelaedicao'" +
                    " data-toggle='modal'>Atualizar</button>";
                conteudo += "&nbsp;"; //espaço
                conteudo += "<button onclick='obterProduto(" +
                    item.IdProduto + ")' class='btn btn-danger" +
                    " btn-sm' data-target='#janelaexclusao'" +
                    " data-toggle='modal'>Excluir</button>";
                conteudo += "</td>";
                conteudo += "</tr>";
            });

            $("#tabela tbody").html(conteudo);
        },

        error: function (e) {
            console.log(e);
        }
    });

};

//quando a página for carregada, execute..
$(document).ready(function () {

    consultarProdutos(); //executando a função

    //criando um evento para realizar a exclusão..
    $("#btnexclusao").click(function () {
        excluirProduto(); //executando a função
    });

    //criando um evento para realizar a edição..
    $("#btnedicao").click(function () {
        atualizarProduto();
    });

});
