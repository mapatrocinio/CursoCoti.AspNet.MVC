//função para realizar o cadastro do produto
function cadastrarProduto() {

    //criar um objeto JSON para armazenar os dados
    //de cada campo da página de cadastro de produto

    var dados = {
        Nome: $("#nome").val(),
        Preco: $("#preco").val(),
        Quantidade: $("#quantidade").val()
    };

    $("#erros").html(""); //limpar as mensagens de erro

    //requisição AJAX para o servidor
    $.ajax({
        type: "POST",
        url: "/Produto/CadastrarProduto",
        data: dados,
        success: function (obj) { //promisse

            $("#mensagem").html(obj);

            //limpar os campos da página
            $("#nome").val("");
            $("#preco").val("");
            $("#quantidade").val("");
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

//quando a página for carregada faça..
$(document).ready(function () {

    //executar um evento quando o usuário
    //clicar no botão de cadastro de produto
    $("#btncadastro").click(function () {
        cadastrarProduto();
    });
})
