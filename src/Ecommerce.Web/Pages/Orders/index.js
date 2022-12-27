(function () {
    var l = abp.localization.getResource('Ecommerce');
    var _service = ecommerce.orders.order;
    var _dataTable = null;
    var DateNow = new Date();

    abp.ui.extensions.entityActions.get('order').addContributor(
        function (actionList) {
            return actionList.addManyTail(
                [
                    {
                        text: l('Edit'),
                        visible: abp.auth.isGranted(
                            'Ecommerce.Example.Update'
                        ),
                        action: function (data) {
                            _editModal.open({
                                id: data.record.id,
                            });
                        },
                    },
                ]
            );
        }
    );

    abp.ui.extensions.tableColumns.get('order').addContributor(
        function (columnList) {
            columnList.addManyTail(
                [
                    {
                        title: l("STT"),
                        render: function (data, type, full, meta) {
                            var table = $('table').DataTable();
                            var info = table.page.info();
                            return info.page * table.page.len() + meta.row + 1;
                        },
                        className: "text_center",
                        orderable: false,
                        width: "5%"
                    },
                    {
                        title: l("Order:CustomerName"),
                        data: 'customerName',
                        orderable: false
                    },
                    {
                        title: l("Order:ShippingAddress"),
                        data: 'shippingAddress',
                    },
                    {
                        title: l("Order:OrderDate"),
                        data: 'orderDate',
                    },
                    {
                        title: l("Order:Ammount"),
                        data: 'ammount',
                    },
                    {
                        title: l("Order:Status"),
                        data: 'status',
                    },
                    {
                        title: l("Actions"),
                        rowAction: {
                            items: abp.ui.extensions.entityActions.get('order').actions.toArray()
                        },
                        width: "12%"
                    }
                ]
            );
        },
        0 //adds as the first contributor
    );

    $(async function () {
        var _$wrapper = $('#OrdersWrapper');
        var input = {
            customerId: $($('#Customers').get(0)).val(),
            orderDate: $('#OrderDate').val() ? $('#OrderDate').val() : DateNow
        }

        _dataTable = _$wrapper.find('table').DataTable(
            abp.libs.datatables.normalizeConfiguration({
                order: [2, 'asc'],
                processing: true,
                paging: true,
                scrollX: true,
                searching: false,
                serverSide: true,
                ajax: abp.libs.datatables.createAjax(_service.search, function () {
                    return input;
                }),
                columnDefs: abp.ui.extensions.tableColumns.get('order').columns.toArray(),
            })
        );

        $('#Customers').select2({
            placeholder: 'Select an option',
            multiple: false
        });

        $('.dataTable_filters').append(
            '<div id="DataTables_Table_0_filter" class="dataTables_filter">' +
                '<label>' +
                    'Tìm kiếm ' +
            '<input type="date" id="OrderDate" class="form-control form-control-sm" min="2018-01-01" aria - controls="DataTables_Table_0" value="' + DateNow.getFullYear() + '-' + DateNow.getMonth() + '-' + DateNow.getDate() +'">' +
                '</label>' +
            '</div > '
        );

        $('#DataTables_Table_0_filter input').on('change', function () {
            input.orderDate = $('#OrderDate').val();
            input.customerId = $($('#Customers').get(0)).val();
            _dataTable.ajax.reload();
        });

        $('#Customers').on('change', function (e) {
            input.orderDate = $('#OrderDate').val();
            input.customerId = $(e.currentTarget).val();
            _dataTable.ajax.reload();
        });
    });
})();
