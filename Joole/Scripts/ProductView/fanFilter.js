$(document).ready(function () {
    $(function () {
        $("#airflow-range").slider({
            range: true,
            min: 0,
            max: 10000,
            values: [0, 10000],
            slide: function (event, ui) {
                $("#airflow-min").val(ui.values[0]);
                $("#airflow-max").val(ui.values[1]);

            }
        });
        //$("#min").val( $("#slider-range").slider("values", 0));
        //$("#max").val( $("#slider-range").slider("values", 1));
    });

    $(function () {
        $("#power-range").slider({
            range: true,
            min: 0,
            max: 300,
            values: [0, 300],
            slide: function (event, ui) {
                $("#power-min").val(ui.values[0]);
                $("#power-max").val(ui.values[1]);

            }
        });
    });

    $(function () {
        $("#sound-range").slider({
            range: true,
            min: 0,
            max: 80,
            values: [0, 80],
            slide: function (event, ui) {
                $("#sound-min").val(ui.values[0]);
                $("#sound-max").val(ui.values[1]);

            }
        });
    });

    $(function () {
        $("#fan-diameter-range").slider({
            range: true,
            min: 30,
            max: 100,
            values: [30, 100],
            slide: function (event, ui) {
                $("#fan-diameter-min").val(ui.values[0]);
                $("#fan-diameter-max").val(ui.values[1]);

            }
        });
    });

});
    