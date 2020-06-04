$(document).ready(function () {

    $(function () {
        $("#power-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [75, 300],
            slide: function (event, ui) {
                $("#power-min").val(ui.values[0]);
                //$("#power-min").attr('name',ui.values[0]);
                $("#power-max").val(ui.values[1]);
                /*$("#power-max").attr('name', ui.values[1]);*/

            }
        });
    });

    $(function () {
        $("#volt-range").slider({
            range: true,
            min: 0,
            max: 300,
            values: [75, 300],
            slide: function (event, ui) {
                $("#volt-min").val(ui.values[0]);
                /*$("#volt-min").attr('name', ui.values[0]);*/
                $("#volt-max").val(ui.values[1]);
                /*$("#volt-max").attr('name', ui.values[1]);*/
            }
        });
    });

    $(function () {
        $("#cord-range").slider({
            range: true,
            min: 0,
            max: 5,
            values: [0, 5],
            slide: function (event, ui) {
                $("#cord-min").val(ui.values[0]);
                //$("#cord-min").attr('name', ui.values[0]);
                $("#cord-max").val(ui.values[1]);
                //$("#cord-max").attr('name', ui.values[1]);
            }
        });
    });

    $(function () {
        $("#Capacity-range").slider({
            range: true,
            min: 0,
            max: 5,
            values: [0, 5],
            slide: function (event, ui) {
                $("#Capacity-min").val(ui.values[0]);
                //$("#Capacity-min").attr('name', ui.values[0]);
                $("#Capacity-max").val(ui.values[1]);
                //$("#Capacity-max").attr('name', ui.values[1]);
            }
        });
    });

});
