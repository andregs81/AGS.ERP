function SalvarCliente() {
    var url = "/Cliente/Create";
    var cliente = $("#FormCliente").serialize();
    $.ajax({
        url: url,
        type: "POST",
        datatype: "json",
        data: cliente,
        success: function (data) {
            if (data.clienteId > 0) {
                var id = data.clienteId;
                $("#ClienteId").val(id);
                ListarEndereco(data.clienteId);
                $("#DivCamposEndereco").remove();
                $("#btnSalvarCliente").attr("disabled", "disabled");
                toastr.success('Cliente ' + id + ' cadastrado com sucesso!')
            }
        }
        , error: function (dataError) {
            var msg = dataError.responseText;
            console.log(dataError.responseText);
            toastr.error(msg);
        }
    });
}

function EditarCliente(idCliente) {
    var url = "/Cliente/Edit";
    var form = $("#FormCliente").serialize();

    $.ajax({
        url: url,
        type: "POST",
        datatype: "json",
        data: form,
        success: function () {
            window.location.href = "/Cliente/Index";
        },
        error: function () {
            alert("Erro durante a requisição");
        }
    });
}

function selecionaTipoPessoa(tipo){
    if(tipo === 'J'){
        $("#CPF").val(null);
        $("#DIVCPF").hide();
        $("#DIVCNPJ").show();
    }
    else {
        $("#CNPJ").val(null);
        $("#DIVCNPJ").hide();
        $("#DIVCPF").show();
    }
     
}



