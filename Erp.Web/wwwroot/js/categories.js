$(document).ready(function () {

    var table = $('#categoriesTable').DataTable({
        processing: true,
        serverSide: true,
        searching: false,
        ajax: {
            url: '/Admin/Categories/GetCategories', 
            type: 'POST',
            data: function (d) {
                d.Name = $('#Name').val();
                d.BrandId = $('#BrandId').val();
                d.Search = $('#Search').val();
                var isActiveValues = [];
                if ($('#ActiveCheck').is(':checked')) isActiveValues.push(true);
                if ($('#InactiveCheck').is(':checked')) isActiveValues.push(false);
                d.IsActiveValues = isActiveValues;
            }
        },
        columns: [
            { data: 'id', name: 'Id'},
            { data: 'name', name: 'Name' },
            { data: 'brandName', name: 'BrandName'},
            { data: 'status', name: 'Status',},
          
        ],
        order: [[0, 'asc']],
        language: {
            url: '//cdn.datatables.net/plug-ins/1.13.4/i18n/ar.json'
        }
    });

    $('#btnFilter').on('click', function () {
        table.ajax.reload();
    });

    $('#btnReset').on('click', function () {
        $('#filterForm')[0].reset();
        table.ajax.reload();
    });
});
