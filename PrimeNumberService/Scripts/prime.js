$(document).ready(function () {
    $.ajax({
        type: "get",
        contentType: "application/json; charset=utf-8",
        url: "PrimeNumber.svc/GetPrimes",
        data: "{}",
        dataType: "json",
        success: function (data) {
            $("#autocomplete").autocomplete({
                source: data
            });
        }
    });
    $("#autocomplete2").autocomplete({
        source: function (request, response) {
            if (!$("#root").valid()) {
                return;
            }
            $.ajax({
                type: "get",
                contentType: "application/json; charset=utf-8",
                url: "PrimeNumber.svc/GetPrimesStartedAt",
                dataType: "json",
                data: {
                    beginSigns: request.term
                },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item,
                            value: item
                        }
                    }));
                }
            });
        }
    });
    $("#root").validate({
        rules: {
            autocomplete: {
                number: true
            },
            autocomplete2: {
                number: true
            }
        }
    });
});