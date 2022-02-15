$(function () {
    var l = abp.localization.getResource('livraria');
    var createModal = new abp.ModalManager(abp.appPath + 'Authors/CreateModal');
    var editmodal  = new abp.ModalManager(abp.appPath + 'Authors/EditModal');

    //var dataTable = $('#AuthorsTable').DataTable(
    //abp.libs.datatables.normalizeConfiguration({
    //    serverSide: true,
    //    paging: true,
    //    order: [[1, "asc"]],
    //    searching: false,
    //    scrollX: true,
    //    ajax: abp.libs.datatables.createAjax(livraria.authors.author.getList),
    //    columnDefs: [
    //        {
    //            title: l('Actions'),
    //            rowAction: {
    //                items:
    //                    [
    //                        {
    //                            text: l('Edit'),
    //                            visible: abp.auth.isGranted('livraria.Authors.Edit'),
    //                            action: function (data) {
    //                                editModal.open({ id: data.record.id });
    //                            }
    //                        },
    //                        {
    //                            text: l('Delete'),
    //                            visible: abp.auth.isGranted('livraria.Authors.Delete'),
    //                            confirmMessage: function (data) {
    //                                return l('AuthorDeletionConfirmationMessage',
    //                                    data.record.name
    //                                );
    //                            },
    //                            action: function (data) {
    //                                livraria.authors.author
    //                                    .delete(data.record.id)
    //                                    .then(
    //                                        DeletadoComSucesso()
    //                                    )
    //                            }
    //                        }
    //                    ]
    //            }
    //        },
    //        {
    //            title: l('Name'),
    //            data: 'name'
    //        },
    //        {
    //            title: l('BirthDate'),
    //            data: 'birthDate',
    //            render: function (data) {
    //                return luxon.DateTime
    //                    .fromISO(data, {
    //                        locale: abp.localization.currentCulture.name
    //                    }).toLocaleString();
    //            }

    //        }
    //    ]
    //})
    //);

var dataTable = $('#AuthorsTable').DataTable(
    abp.libs.datatables.normalizeConfiguration({
        serverSide: true,
        paging: true,
        order: [[1, "asc"]],
        searching: false,
        scrollX: true,
        ajax: abp.libs.datatables.createAjax(livraria.authors.author.getList),
        columnDefs: [
            {
                title: l('Actions'),
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible:
                                    abp.auth.isGranted('livraria.Authors.Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible:
                                    abp.auth.isGranted('livraria.Authors.Delete'),
                                confirmMessage: function (data) {
                                    return l(
                                        'AuthorDeletionConfirmationMessage',
                                        data.record.name
                                    );
                                },
                                action: function (data) {
                                    livraria.authors.author
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(
                                                l('SuccessfullyDeleted')
                                            );
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('Name'),
                data: "name"
            },
            {
                title: l('BirthDate'),
                data: "birthDate",
                render: function (data) {
                    return luxon
                        .DateTime
                        .fromISO(data, {
                            locale: abp.localization.currentCulture.name
                        }).toLocaleString();
                }
            }
        ]
    })
);
createModal.onResult(function () {
    dataTable.ajax.reload();
});

editmodal.onResult(function () {
    dataTable.ajax.reload();
});

$('#NewAuthorButton').click(function (e) {
    e.preventDefault();
    createModal.open();
});


function DeletadoComSucesso() {
    abp.notify.info(
        l('SucessfullyDeleted')
    );
    dataTable.ajax.reload();
}





}
);