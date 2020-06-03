$(document).ready(function () {

    $(function () {
        $("#power-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [75, 300],
            slide: function (event, ui) {
                $("#power-min").val(ui.values[0]);
                $("#power-max").val(ui.values[1]);

            }
        });
    });

    $(function () {
        $("#volt-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [75, 300],
            slide: function (event, ui) {
                $("#volt-min").val(ui.values[0]);
                $("#volt-max").val(ui.values[1]);

            }
        });
    });

    $(function () {
        $("#cord-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [75, 300],
            slide: function (event, ui) {
                $("#cord-min").val(ui.values[0]);
                $("#cord-max").val(ui.values[1]);

            }
        });
    });

    $(function () {
        $("#Capacity-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [75, 300],
            slide: function (event, ui) {
                $("#Capacity-min").val(ui.values[0]);
                $("#Capacity-max").val(ui.values[1]);

            }
        });
    });

});
