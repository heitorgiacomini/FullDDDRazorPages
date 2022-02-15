$(function () {
    var localization = abp.localization.getResource('livraria');
   
    var dataTable = $('#BooksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(livraria.books.book.getList),
            columnDefs: [
                {
                    title: localization('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: localization('Edit'),
                                    visible: abp.auth.isGranted('BookStore.Books.Edit'), //CHECK for the PERMISSION
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: localization('Delete'),
                                    visible: abp.auth.isGranted('BookStore.Books.Delete'), //CHECK for the PERMISSION
                                    confirmMessage: function (data) {
                                        return localization(
                                            'BookDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        livraria.books.book
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    localization('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: localization('Name'),
                    data: "name"
                },
                {
                    title: localization('Type'),
                    data: "type",
                    render: function (data) {
                        return localization('Enum:BookType:' + data);
                    }
                },
                {
                    title: localization('PublishDate'),
                    data: "publishDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: localization('Price'),
                    data: "price"
                },
                {
                    title: localization('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );


    var createModal = new abp.ModalManager(abp.appPath + 'Books/CreateModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    var editModal = new abp.ModalManager(abp.appPath + 'Books/EditModal');

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
