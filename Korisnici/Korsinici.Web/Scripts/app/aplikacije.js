MVCAdmin.Pages.Aplikacije = function() {

    var self = this,
        grid,
        btnDodaj;

    $(function() {

        btnDodaj = $("#btnDodaj").jqxButton({
            theme: MVCAdmin.defaultTheme
        });

        var dataSource = new $.jqx.dataAdapter({
            url: $("#getUrl").val(),
            datatype: 'json',
            id: 'Id',
            datafields: [
                { name: 'Id' },
                { name: 'Kod' },
                { name: 'Naziv' },
                { name: 'HomeUrl' },
                { name: 'Logo' },
                { name: 'Aktivan', type: 'bool' }
                
            ],
            updaterow: function(rowId, value, commit) {
                $.ajax({
                    url: $("#updateUrl").val(),
                    type: 'POST',
                    contentType: 'application/json; charset=UTF-8',
                    data: JSON.stringify(value),
                    success: function (response) {
                        commit(true);
                        switch (response) {
                            case 1:
                                grid.jqxGrid('updatebounddata');
                            case 2:
                                MVCAdmin.success('Podaci su uspešno sačuvani');
                                break;
                            default:
                        }
                    }
                });
            },
        });

        grid = $("#aplikacijeGrid");
        grid.jqxGrid({
            theme: MVCAdmin.defaultTheme,
            columnsheight: 34,
            editable: true,
            columns: [
                { text: 'Kod', datafield: 'Kod', validation: _required },
                { text: 'Naziv aplikacije', datafield: 'Naziv', validation: _required },
                { text: 'Home URL', datafield: 'HomeUrl', validation: _required },
                { text: 'Logo', datafield: 'Logo' },
                { text: 'Aktivan', datafield: 'Aktivan', columntype: 'checkbox', width: 64 }
            ],
            source: dataSource,
            width: 1014
        });
        

        // Events
        btnDodaj.on('click', function() {
            grid.jqxGrid('addrow', -1, {});
        });
    });

    function _required(cell, value) {
        if (!value) {
            return { result: false, message: 'Unesite vrednost' };
        }
        return true;
    }
};

MVCAdmin.Pages.Aplikacije = new MVCAdmin.Pages.Aplikacije();