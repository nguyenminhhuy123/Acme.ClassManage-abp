$(function () {
    var l = abp.localization.getResource('ClassManage');
    var createModal = new abp.ModalManager(abp.appPath + 'Commons/LopHoc/CreateModal'); 
    var editModal = new abp.ModalManager(abp.appPath + 'Commons/LopHoc/EditModal');


    var dataTable = $('#ClassTableLopHoc').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.classManage.common.lopHoc.getList),
            columnDefs: [

                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('Common.LopHoc.Update'),
                                       
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('Common.LopHoc.Delete'),
                                    confirmMessage: function (data) {
                                        return l('BookDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        acme.classManage.common.lopHoc
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
                    title: l('ghichu'),
                    data: "ghiChu",
                   
                   
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

    $('#insertlophoc').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    $('#searchsubmit').click(function () {
        dataTable.destroy();
        var inputAction = function (requestData, dataTableSettings) {
            return {
                Keyword: $('#searchinput').val(),
                SkipCount: 0,
                MaxResultCount: 9
            };
        };

             dataTable = $('#ClassTableLopHoc').DataTable(
            abp.libs.datatables.normalizeConfiguration({
                processing: true,
                serverSide: true,
                paging: true,
                order: [[1, "asc"]],
                searching: false,
                scrollX: true,
                autoWith: true,
                fixedColumns: true,
                fixedHeader: true,
                bLengthChange: false,
                scrollCollapse: true,
                ordering: true,

           

         

                ajax: abp.libs.datatables.createAjax(acme.classManage.common.lopHoc.search, function () {
                    return {
                        keyword: $('#searchinput').val(),
                        maxResultCount: 1000,
                        skipCount:1
                      
                    };
                }),
                
                columnDefs: [
                    {
                        title: l('Actions'),
                        rowAction: {
                            items:
                                [
                                    {
                                        text: l('Edit'),
                                        visible: abp.auth.isGranted('Common.LopHoc.Update'),

                                        action: function (data) {
                                            editModal.open({ id: data.record.id });
                                        }
                                    },
                                    {
                                        text: l('Delete'),
                                        visible: abp.auth.isGranted('Common.LopHoc.Delete'),
                                        confirmMessage: function (data) {
                                            return l('BookDeletionConfirmationMessage', data.record.name);
                                        },
                                        action: function (data) {
                                            acme.classManage.common.lopHoc
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
                        title: l('ghichu'),
                        data: "ghiChu",


                    },

                ]
            })
        );
    });

});




