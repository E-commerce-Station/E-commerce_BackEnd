(function () {
    var l = abp.localization.getResource('Ecommerce');
    var _service = ecommerce.categories.category;
    var _editModal = new abp.ModalManager(
        abp.appPath + 'Categories/EditModal'
    );
    var _createModal = new abp.ModalManager(
        abp.appPath + 'Categories/CreateModal'
    );

    _createModal.onResult(function () {
        _dataTable.ajax.reload();
    });

    _editModal.onResult(function () {
        _dataTable.ajax.reload();
    });

    $('#NewCategoryButton').click(function (e) {
        e.preventDefault();
        _createModal.open();
    });

    var _dataTable = null;

    abp.ui.extensions.entityActions.get('category').addContributor(
        function (actionList) {
            return actionList.addManyTail(
                [
                    {
                        text: l('Edit'),
                        visible: abp.auth.isGranted(
                            'Ecommerce.Category.Update'
                        ),
                        action: function (data) {
                            _editModal.open({
                                id: data.record.id,
                            });
                        },
                    },
                    {
                        text: l('Delete'),
                        visible: abp.auth.isGranted(
                            'Ecommerce.Category.Delete'
                        ),
                        confirmMessage: function (data) {
                            return l(
                                'ExampleDeletionConfirmationMessage',
                                data.record.name
                            );
                        },
                        action: function (data) {
                            _service
                                .delete(data.record.id)
                                .then(function () {
                                    _dataTable.ajax.reload();
                                    abp.notify.success(l('SuccessfullyDeleted'));
                                });
                        },
                    }
                ]
            );
        }
    );

    abp.ui.extensions.tableColumns.get('category').addContributor(
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
                        title: l("Category:Name"),
                        data: 'name',
                    },
                    {
                        title: l("Category:Note"),
                        data: 'description',
                    },
                    {
                        title: l("Category:Thumbnail"),
                        data: 'thumbnail',
                        render: function(data) { return '<span class="' + data + '"></span>' },
                        orderable: false
                    },
                    {
                        title: l("Actions"),
                        rowAction: {
                            items: abp.ui.extensions.entityActions.get('category').actions.toArray()
                        },
                        width: "12%"
                    }
                ]
            );
        },
        0 //adds as the first contributor
    );

    $(function () {
        var _$wrapper = $('#CategoryWrapper');

        _dataTable = _$wrapper.find('table').DataTable(
            abp.libs.datatables.normalizeConfiguration({
                order: [1, 'asc'],
                processing: true,
                paging: true,
                scrollX: true,
                serverSide: true,
                ajax: abp.libs.datatables.createAjax(_service.search),
                columnDefs: abp.ui.extensions.tableColumns.get('category').columns.toArray(),
            })
        );

        _createModal.onResult(function () {
            _dataTable.ajax.reload();
        });

        _editModal.onResult(function () {
            _dataTable.ajax.reload();
        });

        _$wrapper.find('button[name=CreateCategory]').click(function (e) {
            e.preventDefault();
            _createModal.open();
        });

        _$wrapper.find('button[name=EditCategory]').click(function (e) {
            e.preventDefault();
            _editModal.open({
                id: 'id'
            });
        });
    });
})();
