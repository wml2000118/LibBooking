var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#reservationsTable').DataTable({
        "ajax": { url: '/api/reservations/get-all-reservations' },
        "columns": [
            { data: 'room.roomName', "width": "15%" },
            {
                data: 'reservationDate', "width": "15%",
                render: function (data) {
                    return moment(data).format('YYYY-MM-DD'); // Use moment.js to format date
                }
            },
            { data: 'startTime', "width": "10%" },
            { data: 'endTime', "width": "10%" },
            { data: 'email', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                        <a href="/api/reservations/edit/${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                        <a onClick=Delete('/api/reservations/delete-reservation/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`;
                },
                "width": "25%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            });
        }
    });
}
