$(function () {
    var l = abp.localization.getResource('ClassManage');
    var createModal = new abp.ModalManager(abp.appPath + 'Commons/SinhVien/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Commons/SinhVien/EditModal');


    var dataTable = $('#ClassTableSinhVien').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.classManage.common.sinhVien.getList),
            columnDefs: [

                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l('BookDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        acme.classManage.common.sinhVien
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
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
                    title: l('Tuoi'),
                    data: "tuoi",


                },
                {
                    title: l('CMND'),
                    data: "cmnd",


                },
                {
                    title: l('Bo Phan'),
                    data: "lopHocID",


                },



            ]
        })
    );


    createModal.onResult(function () {

        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#insertsinhvien').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});


