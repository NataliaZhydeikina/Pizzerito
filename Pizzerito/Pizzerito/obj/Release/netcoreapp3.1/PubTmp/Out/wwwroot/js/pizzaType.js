﻿


var dataTable;


$(document).ready(function () {
    loadList();

});

function loadList() {
    dataTable = $('#DT-load').DataTable({

        "ajax": {
            "url": "/api/MenuType",
            "type": "GET",
            "datatype": "json"
        },

        "columns": [
            { "data": "name", "defaultContent": "", "autoWidth": true  },
            { "data": "description", "defaultContent": "", "width": "30%"  },
            { "data": "price", "defaultContent": "","autoWidth": true  },
            { "data": "category.name", "defaultContent": "", "autoWidth": true  },
            { "data": "toppingType.name", "defaultContent": "", "autoWidth": true  },
            { "data": "pizzaSize.size", "defaultContent": "", "autoWidth": true  },
            {
                "data": "id",
                "render": function (data) {
                    return ` <div class="text-center">
                                <a href="/Admin/MenuType/upsert?id=${data}" class="btn btn-success text-light" style="cursor:pointer; width:100px;">
                                    <i class="far fa-edit"></i> Edit
                                </a>
                                <a class="btn btn-danger text-light" style="cursor:pointer; width:100px;" onclick=Delete('/api/MenuType/'+${data})>
                                    <i class="far fa-trash-alt"></i> Delete
                                </a>
                             </div>
                           
                           `;
                }, "autoWidth": true 
            }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%",
        "scrollX": 200
       
        
    });
}


function Delete(url) {
    swal({
        title: "Are you sure you want to Delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}