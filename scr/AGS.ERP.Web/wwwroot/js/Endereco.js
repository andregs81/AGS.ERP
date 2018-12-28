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
    items = response;
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

    var url = "/Endereco/CreateEnderecoCliente";
    $.ajax({
        url: url
        , type: "POST"
        , data: form
        , datatype: "json"
        , success: function (data) {
            if (data.enderecoId > 0) {
                var clienteId = data.clienteId;

                modalClose();
                ListarEndereco(clienteId);
            } else {
                toastr.error("Ops ocorreram problemas ao salvar o endereço!");
            }
        }
        , error: function () {
            toastr.error("Erro na requisição ao servidor!");
        }
    });
}

function editEndereco(id) {

    var url = "/Endereco/EditEnderecoCliente";
    $.ajax({
        url: url
        , type: "GET"
        , datatype: "html"
        , data: { id: id }
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

function detalhesEndereco(id) {

    var url = "/Endereco/EditEnderecoCliente";
    $.ajax({
        url: url
        , type: "GET"
        , datatype: "html"
        , data: { id: id }
        , success: function (data) {
            jQuery.noConflict();
            $('#modalEnderecoDetalhes').modal('show');
            var divCampoEndereco = $("#modalEnderecoDetalhes #divCamposEndereco");
            divCampoEndereco.empty();
            divCampoEndereco.html(data);

            $("#EnderecoId").val(id);

            $("#modalEnderecoDetalhes select").prop('disabled', true);
            $("#modalEnderecoDetalhes input").prop('disabled', true);
        }

    });
}

function confirmDeleteEndereco(id) {
    jQuery.noConflict();
    $("#idEnderecoDelete").val(id);

    $("#modalDelete").modal('show');
}

function deleteEndereco() {
    const id = $("#idEnderecoDelete").val();
    if (id !== null || id !== undefined) {
        let url = `/Endereco/Delete/${id}`;
        $.post(url, () => {
            toastr.success(`Endereço ${id} removido com sucesso`);

            $('#modalDelete').modal('hide');
            $('.modal-backdrop').css('display', 'none');

            let clienteId = $("#ClienteId").val();
            ListarEndereco(clienteId);
        })
            .fail(() => {
                toastr.clear("Erro ao excluir endereço");
            });
    }
    
    console.log(id);
}

function obterEnderecoCep(cep) {
    if (!cep)
        return;

    var url = `https://viacep.com.br/ws/${cep}/json/`;

    $.ajax({
        url: url
        , type: "GET"
        , datatype: "json"
        , success: function (data) {
            limparCampos();
            setEndereco(data);
        }
        , error: function () {
            toastr.error(`Cep ${cep} não encontrado!`);
        }
    });
}

function setEndereco(json) {

    const idCidade = cidadeCodeByName(json.localidade, json.uf);
    console.log(idCidade);

    $('input[name=Logradouro]').val(json.logradouro);
    $('input[name=Numero]').val(json.numero);
    $('input[name=Complemento]').val(json.complemento);
    $('input[name=Bairro]').val(json.bairro);
    //$('select[name=CidadeId]').val(idCidade);
    $('select[name=UF]').val(json.uf);
}

function limparCampos() {

    $('input[name=Logradouro]').val('');
    $('input[name=Numero]').val('');
    $('input[name=Complemento]').val('');
    $('input[name=Bairro]').val('');
    $('select[name=CidadeId]').val('');
    $('select[name=UF]').val('');
}

function cidadeCodeByName(nome, uf) {
    var url = "/Endereco/ObterCidadeIdByName";

    $.get(url, { cidade: nome, uf: uf }, function (data) {

        $('select[name=CidadeId]').val(data.id);
    });

}
