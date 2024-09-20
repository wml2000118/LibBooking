var dataTable;

$(document).ready(function () {
    loadDataTable();
    showTempDataMessage(); // Show messages based on TempData
});

function loadDataTable() {
    dataTable = $('#adminDashboardTable').DataTable({
        "ajax": { url: '/api/LibrarianAppointment/get-all-appointments' },
        "columns": [
            { data: 'librarian.name', "width": "15%" },
            { data: 'userEmail', "width": "20%" },
            {
                data: 'appointmentDate', "width": "10%",
                render: function (data) {
                    return moment(data).format('YYYY-MM-DD');
                }
            },
            { data: 'startTime', "width": "10%" },
            { data: 'endTime', "width": "10%" },
            { data: 'notes', "width": "30%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                        <a href="/api/LibrarianAppointment/edit/${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                        <a onClick=Delete('/api/LibrarianAppointment/delete-appointment/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`;
                },
                "width": "20%"
            }
        ],
        "autoWidth": false // Ensure DataTable doesn't automatically calculate the column widths
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
                    dataTable.ajax.reload(); // Reload the data in the DataTable
                    toastr.success(data.message); // Display a success message
                }
            });
        }
    });
}

// Function to show TempData message using toastr
function showTempDataMessage() {
    const message = '@TempData["Message"]';
    const messageType = '@TempData["MessageType"]';

    if (message && messageType) {
        if (messageType === "success") {
            toastr.success(message);
        } else if (messageType === "error") {
            toastr.error(message);
        }
    }
}
