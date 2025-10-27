$(document).ready(function () {

    if ($('#DATATABLE_USAURIO').length > 0) {

        let cols = $($($($('#DATATABLE_USAURIO')[0].childNodes)[1].childNodes)[1])[0].children.length

        CreateDataTable(
            "DATATABLE_USAURIO",
            cols,
            false,
            [],
            [[0, "asc"]],
            10
        )
    }
});