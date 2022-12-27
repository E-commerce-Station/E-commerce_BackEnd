(function () {
    var l = abp.localization.getResource('Ecommerce');
    var _service = ecommerce.customers.customer;

    var _dataTable = null;

    abp.ui.extensions.entityActions.get('customer').addContributor(
        function (actionList) {
            return actionList.addManyTail(
                [
                    {
                        text: l('Customer:Order'),
                        visible: abp.auth.isGranted(
                            'Ecommerce.Order'
                        ),
                        action: function (data) {
                            location.href = "./Orders?CustomerId=" + data.record.id;
                        },
                    },
                ]
            );
        }
    );
      
    abp.ui.extensions.tableColumns.get('customer').addContributor(
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
                        title: l("Customer:Name"),
                        data: 'name',
                    },
                    {
                        title: l("Customer:Email"),
                        data: 'email',
                    },
                    {
                        title: l("Customer:Address"),
                        data: { address: 'address', country: 'country' },
                        render: function (data) {
                            return data.address + ',' + data.country;
                        }
                    },
                    {
                        title: l("Customer:Phone"),
                        data: 'phone',
                    },
                    {
                        title: l("Customer:Email"),
                        data: 'cccd',
                    },
                    {
                        title: l("Actions"),
                        rowAction: {
                            items: abp.ui.extensions.entityActions.get('customer').actions.toArray()
                        },
                        width: "12%"
                    }
                ]
            );
        },
        0 //adds as the first contributor
    );

    $(function () {
        var _$wrapper = $('#CustomersWrapper');

        _dataTable = _$wrapper.find('table').DataTable(
            abp.libs.datatables.normalizeConfiguration({
                order: [1, 'asc'],
                processing: true,
                paging: true,
                scrollX: true,
                serverSide: true,
                ajax: abp.libs.datatables.createAjax(_service.search),
                columnDefs: abp.ui.extensions.tableColumns.get('customer').columns.toArray(),
            })
        );
    });
})();
