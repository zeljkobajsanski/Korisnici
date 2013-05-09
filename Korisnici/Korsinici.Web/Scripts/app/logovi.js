MVCAdmin.Pages.Logovi = function() {

    var self = this;

    $(function() {

        self.odDatuma = $("#odDatuma");
        self.doDatuma = $("#doDatuma");
        self.aplikacijeCombo = $("#aplikacijeCombo");
        self.logoviGrid = $("#logovi");
        self.viewmodel = JSON.parse($("#viewmodel").val());
        var btnRefresh = $("#btnRefresh");

        self.odDatuma.jqxDateTimeInput({ theme: MVCAdmin.defaultTheme, formatString: 'dd.MM.yyyy' });

        self.doDatuma.jqxDateTimeInput({ theme: MVCAdmin.defaultTheme, formatString: 'dd.MM.yyyy' });

        self.viewmodel.Aplikacije.unshift({label: 'Sve', value: ''});
        self.aplikacijeCombo.jqxDropDownList({
            theme: MVCAdmin.defaultTheme,
            source: self.viewmodel.Aplikacije,
            displayMember: 'Naziv',
            valueMember: 'Naziv',
            placeHolder: 'Filtriraj po aplikaciji...'
        });

        btnRefresh.jqxButton({ theme: MVCAdmin.defaultTheme });

        self.logoviGrid.jqxGrid({
            theme: MVCAdmin.defaultTheme,
            width: MVCAdmin.gridFullWidth,
            columns: [
                { text: 'Korisnik', datafield: 'KorisnickoIme'},
                { text: 'Aplikacija', datafield: 'Aplikacija'},
                { text: 'IP Adresa', datafield: 'IpAdresa'},
                { text: 'Browser', datafield: 'Browser', cellsrenderer: _renderujBrowser, width: 48},
                { text: 'Vreme Prijave', datafield: 'DatumPrijave', cellsformat: 'dd.MM.yyyy HH:mm'},
                { text: 'Poslednja Aktivnost', datafield: 'VremePoslednjeAktivnosti', cellsformat: 'dd.MM.yyyy HH:mm:ss' },
                { text: 'Online', datafield: 'VremeNeaktivnosti', cellsrenderer: _renderujOnlineStatus, width: 48 }
            ],
            pageable: true
        });
        
        self.OsveziLogove();
        
        // events
        self.odDatuma.on('valuechanged', self.OsveziLogove);
        self.doDatuma.on('valuechanged', self.OsveziLogove);
        self.aplikacijeCombo.on('change', self.OsveziLogove);
        btnRefresh.on('click', self.OsveziLogove);
    });
    
    self.OsveziLogove = function() {
        var izabranaAplikacija = self.aplikacijeCombo.jqxDropDownList('getSelectedItem');
        
        var datasource = new $.jqx.dataAdapter({
            url: $("#VratiLogove").val(),
            datatype: 'json',
            data: {
                nazivAplikacije: izabranaAplikacija ? izabranaAplikacija.value : '',
                odDatuma: moment(self.odDatuma.jqxDateTimeInput('getDate')).format(),
                doDatuma: moment(self.doDatuma.jqxDateTimeInput('getDate')).format(),
            },
            datafields: [
                { name: 'KorisnickoIme' },
                { name: 'Aplikacija' },
                { name: 'IpAdresa' },
                { name: 'Browser' },
                { name: 'DatumPrijave', type: 'date'  },
                { name: 'VremePoslednjeAktivnosti', type: 'date' },
                { name: 'VremeNeaktivnosti', type: 'number' },
            ]
        });
        self.logoviGrid.jqxGrid({ source: datasource });
    };

    function _renderujOnlineStatus(row, column, cell) {
        var src;
        if (cell <= 10) {
            //src = '/Content/images/bullet_green.png';
            src = '/Content/images/successGreenDot.png';
        } else if (cell <= 30) {
            src = '/Content/images/warningOrangeDot.png';
        } else {
            src = '/Content/images/errorRedDot.png';
        }
        return '<img src="' + src + '" alt="" style="padding: 5px 0 0 16px"/>';
    }
    
    function _renderujBrowser(row, value, cell) {
        var src = '';
        if (cell === 'Chrome') {
            src = '/Content/images/chrome.png';
        } else if (cell === 'Firefox') {
            src = '/Content/images/firefox.png';
        } else if (cell === 'MSIE'){
            src = '/Content/images/ie.png';
        } else if (cell === 'Opera') {
            src = '/Content/images/opera.png';
        } else if (cell === 'Android') {
            src = '/Content/images/android-icon.png';
        }
        return '<img src="' + src + '" alt="" style="padding: 4px 0 0 16px" />';
    }
};

MVCAdmin.Pages.Logovi = new MVCAdmin.Pages.Logovi();