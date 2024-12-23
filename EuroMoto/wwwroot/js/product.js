

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable(){
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'name', "width": "25%" },
            { data: 'producent', "width": "15%" },
            { data: 'serialNumber', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'category.name', "width": "10%" },
            {
                data: 'id',
                "render": function(data){
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"><i class = "bi bi-pencil-square"></i>Edytuj</a>

                    <a href="" class="btn btn-danger mx-2"><i class = "bi bi-trash"></i>Usuń</a>

                     </div>`
                },
                "width": "25%"
            }
        ]
    });
}
