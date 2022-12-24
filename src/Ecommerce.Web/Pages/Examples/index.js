$(function () {
    var l = abp.localization.getResource('Ecommerce');

    var service = ecommerce.examples.example;
    var createModal = new abp.ModalManager(abp.appPath + 'Examples/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Examples/EditModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewExampleButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    var dataTable = $('#ExampleTable').DataTable();
    Search();

    $('#Search').click(function () {
        Search();
    });

    $('#keyword').keypress(function (event) {
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == 13) {
            Search();
        }
    });

    function Search() {
        var input = {
            'keyword': $("#keyword").val(),
        }

        dataTable = $('#ExampleTable').DataTable(abp.libs.datatables.normalizeConfiguration({
            processing: true,
            serverSide: true,
            paging: true,
            searching: false,
            autoWidth: true,
            fixedColumns: true,
            fixedHeader: true,
            bLengthChange: false,
            scrollCollapse: true,
            bDestroy: true,
            ordering: false,
            ajax: abp.libs.datatables.createAjax(service.search, function () {
                return input;
            }),
            columnDefs: [
                {
                    render: function (data, type, full, meta) {
                        var table = $('#ExampleTable').DataTable();
                        var info = table.page.info();
                        return info.page * table.page.len() + meta.row + 1;
                    },
                    className: "text_center",
                    width: "5%"
                },
                { data: "name", className: "text_center" },
                { data: "note" },
                {
                    className: "action_table",
                    data: "id", render: function (data) {
                        var htmlRender = '';
                        if (abp.auth.isGranted('Ecommerce.Example.Update')) {
                            htmlRender += '<button title="' + l("TitleUpdate") + '" class="btn-action btn-edit" type="button" _type="edit" _id="'
                                + data + '"><i class="fa fa-pencil-square-o"></i></button>';
                        }
                        if (abp.auth.isGranted('Ecommerce.Example.Delete')) {
                            htmlRender += '<button title="' + l("TilteDel") + '" class="btn-action btn-delete" _type="delete" type="button" _id="'
                                + data + '"><i class="fa fa-trash-o"></i> </button>';
                        }
                        return htmlRender;
                    },
                    width: "10%",
                },
            ],
            "fnDrawCallback": function (oSettings) {
                if ($('#ExampleTable').DataTable().page.info().pages < 2) {
                    $('.dataTable_footer').hide();
                } else {
                    $('.dataTable_footer').show();
                }
            }
        }))
    }

    $('#ExampleTable tbody').on('click', 'button', function () {
        var id = $(this).attr("_id");
        if ($(this).attr("_type") === "edit") {
            editModal.open({ id: id });
        } else {
            abp.message.confirm(
                l('ExampleDeletionConfirmationMessage'),
                l('MsgDeleteTitle'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        service.delete(id)
                            .then(function () {
                                abp.notify.info(l('SuccessfullyDeleted'));
                                dataTable.ajax.reload();
                            });
                    }
                });
        }
    });
});