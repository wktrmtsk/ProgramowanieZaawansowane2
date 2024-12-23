

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
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
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"><i class = "bi bi-pencil-square"></i>Edytuj</a>

                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"><i class = "bi bi-trash"></i>Usuń</a>

                     </div>`
                },
                "width": "25%"
            }
        ]
    });
}

    function Delete(url) {
        Swal.fire({
            title: "Czy chcesz usunąć rekord?",
            text: "Jeśli to zrobisz już go nie przywrócisz!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#3085d6",
            cancelButtonColor: "#d33",
            confirmButtonText: "Tak, usuń!",
            cancelButtonText: "Anuluj"
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: url,
                    type: 'DELETE',
                    success: function (data) {
                        toastr.success(data.message);
                    }
                })
            }
        });
    }

