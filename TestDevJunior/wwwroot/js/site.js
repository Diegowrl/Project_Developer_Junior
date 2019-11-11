$(document).on('change', '.capital', function () {
    var money = $(this).val();
    if (money <= 10000) {
        $("#classificacaoInput").val("C");
    } else if (money >= 1000000) {
        $("#classificacaoInput").val("A");
    } else if (money > 10000 && money <= 1000000) {
        $("#classificacaoInput").val("B");
    }
});


$(document).on('change', '.quarentena', function () {
    debugger;
    var value = $(this).val();

    if (value == '') {
        $(this).trigger('change');
    }
    var start = new Date(value),
        end = new Date(),
        diff = new Date(end - start),
        days = diff / 1000 / 60 / 60 / 24;

    if (days > 360) {
        $('#quarentenaInput').prop('checked', true);
    } else {
        $('#quarentenaInput').prop('checked', false);
    }
});

$("#btnSubmitSearch").click(function () {
    console.log("Esta funfando");
    var nameinput = $('#inputRazao').val();
    var cnpjinput = $('#inputCnpj').val();
    var statusinput = $('#statusClient').val();

    console.log(nameinput);
    console.log(cnpjinput);

    $.ajax({
        type: "get",
        url: "Clients/SearchSelected",
        data: {
            Name: nameinput,
            Cnpj: cnpjinput,
            status: statusinput
        },
        success: function (data) {
            $("#resultado").html(data);
        },
        error: function (data) {
            console.log(data);
        }
    });
});

var iid = "";
function openDelete(id, name, cnpj) {
    iid = id;
    $('#modalDelete').modal('show');
    $('.modalBody').html("Deseja realmente deletar o cliente  " + name + " de cnpj:  " + cnpj + "");
}

$("#btnDeleteModal").click(function () {
    console.log(iid);
    $.ajax({
        type: "GET",
        url: "Clients/Delete",
        data: { id: iid },
        success: function (data) {
            console.log(data)
        },
        dataType: "json"
    });
});
