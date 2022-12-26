(function () {
    var l = abp.localization.getResource('Ecommerce');
    var _service = ecommerce.orders.order;
    var _dataTable = null;

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

    $(function () {
        var _$wrapper = $('#OrdersWrapper');

        _dataTable = _$wrapper.find('table').DataTable(
            abp.libs.datatables.normalizeConfiguration({
                order: [2, 'asc'],
                processing: true,
                paging: true,
                scrollX: true,
                serverSide: true,
                ajax: abp.libs.datatables.createAjax(_service.search),
                columnDefs: abp.ui.extensions.tableColumns.get('order').columns.toArray(),
            })
        );
    });
})();
