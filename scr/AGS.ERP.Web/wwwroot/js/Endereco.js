function ListarEndereco(ClienteId) {

    var url = "/Endereco/ListaEnderecoCliente";
    $.ajax({
        url: url
        , type: "GET"
        , data: { idCliente: ClienteId }
        , datatype: "html"
        , success: function (data) {
            var divItens = $("#Enderecos");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    });
}


var items;
function ObterEndereco(id) {
    const url = "/Endereco/ObterEndereco";

    $.ajax({
        url: url
        , type: "POST"
        , data: { id }
        , success: function (response) {
            $('.modal').modal('show');
            //console.log(response);
            onSucess(response);
        }
    });
}


function onSucess(response) {
    debugger;
    items = response;
    console.log(items);
    $('input[name=EnderecoId]').val(items['enderecoId']);
    $('input[name=CEP]').val(items['cep']);
    $('input[name=Logradouro]').val(items['logradouro']);
    $('input[name=Numero]').val(items['numero']);
    $('input[name=Complemento]').val(items['complemento']);
    $('input[name=Bairro]').val(items['bairro']);
    $('select[name=CidadeId]').val(items['cidadeId']);
    $('select[name=UF]').val(items['uf']);
}


function addEndereco() {
    
    var url = "/Endereco/CreateEnderecoCliente";
    $.ajax({
        url: url
        , type: "GET"
        , datatype: "html"
        , success: function (data) {
            jQuery.noConflict();
            $('#modalEndereco').modal('show');
            var divCampoEndereco = $("#divCamposEndereco");
            divCampoEndereco.empty();
            divCampoEndereco.html(data);

        }

    });
}

function modalClose() {
    jQuery.noConflict();
    $('#modalEndereco').modal('hide');
    $('.modal-backdrop').css('display', 'none');
}

function salvarEnderecoCliente() {

    var form = $("#FormCliente").serialize();

    var url = "/Endereco/CreateEnderecoCliente"
    $.ajax({
        url: url
        , type: "POST"
        , data: form
        , datatype: "json"
        , success: function(data){
            if (data.enderecoId > 0) {
                var clienteId = data.clienteId;
                
                modalClose();
                ListarEndereco(clienteId);
            } else{
                alert("Ops ocorreram problemas ao salvar o endereço!");
            }
        }
        ,error: function(){
            alert("Erro na requisição ao servidor!");
        }
    });
}

function editEndereco(id) {
    
    var url = "/Endereco/EditEnderecoCliente";
    $.ajax({
        url: url
        , type: "GET"
        , datatype: "html"
        , data: {id: id}
        , success: function (data) {
            jQuery.noConflict();
            $('#modalEndereco').modal('show');
            var divCampoEndereco = $("#divCamposEndereco");
            divCampoEndereco.empty();
            divCampoEndereco.html(data);

            $("#EnderecoId").val(id);

        }

    });
}