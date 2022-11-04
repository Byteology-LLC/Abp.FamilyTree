$(function () {
    var l = abp.localization.getResource("Human");

    var humanService = window.human.humanity.human;

    var createModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Human/CreateModal",
        scriptUrl: "/Pages/Human/createModal.js",
        modalClass: "humanCreate"
    });

    var editModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Human/EditModal",
        scriptUrl: "/Pages/Human/editModal.js",
        modalClass: "humanEdit"
    });

    var lineageModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Human/LineageModal",
        modalClass: "humanLineage"
    });

    var dataTable = $("#HumanityTable").DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        scrollX: true,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(humanService.getList, null, responseCallback),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l("Edit"),
                                action: function (data) {
                                    editModal.open({
                                        id: data.record.id
                                    });
                                }
                            },
                            {
                                text: l("Lineage"),
                                action: function (data) {
                                    window.open('Human/LineageModal?id=' + data.record.id, '_blank');
                                    //lineageModal.open({
                                    //    id: data.record.id
                                    //});
                                }
                            }
                        ]
                }
            },
            { data: "name" },
            { data: "dateOfBirth" },
            { data: "dateOfDeath" },
            { data: "hairColor" },
            { data: "eyeColor" }
        ]
    }));

    var responseCallback = function (result) {

        // your custom code.

        return {
            recordsTotal: result.totalCount,
            recordsFiltered: result.totalCount,
            data: result.items
        };
    };

    $(document).ready(function () {
        var list = humanService.getList();
        var test = "";
    });

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $("#NewHumanButton").click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});