MVCAdmin.Pages.Korisnici = function() {

	var self = this;

	$(function () {
		
		// Aplikacije dropdown
		self.aplikacijeCombo = $("#aplikacijeCombo");
		self.aplikacijeCombo.jqxDropDownList({
			theme: MVCAdmin.defaultTheme,
			source: JSON.parse($("#aplikacije").val()),
			displayMember: 'Naziv',
			valueMember: 'Id',
			placeHolder: 'Filtriraj po aplikaciji...',
			
		});
		self.aplikacijeCombo.jqxDropDownList('insertAt', { value: -1, label: 'Sve' }, 0);
		self.aplikacijeCombo.on('change', function() {
		    self.Osvezi();
		});

		// Korisnici grid
		self.korisniciGrid = $("#korisniciGrid");
		self.korisniciGrid.jqxGrid({
		    theme: MVCAdmin.defaultTheme,
			editable: true,
			columns: [
				{ text: 'Korisničko ime', editable: false, datafield: 'KorisnickoIme', width: 200 },
				{ text: 'Ime', editable: true, datafield: 'Ime', width: 120 },
				{ text: 'Prezime', editable: true, datafield: 'Prezime' },
				{ text: 'E-mail', editable: true, datafield: 'EMail' },
				{ text: 'Aktivan', editable: true, datafield: 'Aktivan', columntype: 'checkbox', width: 64 }
			],
			width: MVCAdmin.gridFullWidth
		});
	});

	self.IzabranaAplikacija = function() {
		var selected = self.aplikacijeCombo.jqxDropDownList('getSelectedItem');
		return selected ? selected.value : -1;
	};

    self.Osvezi = function() {
        var korisnici = new $.jqx.dataAdapter({
            url: $("#VratiKorisnike").val(),
            datatype: 'json',
            data: { idAplikacije: self.IzabranaAplikacija() },
            updaterow: self.Update
        });
        self.korisniciGrid.jqxGrid({ source: korisnici });
    };

    self.Update = function(rowid, value, commit) {
        $.ajax({
            url: $("#Update").val(),
            type: 'POST',
            contentType: 'application/json; charset=UTF-8',
            data: JSON.stringify(value),
            success: function(responseCode) {
                
                switch (responseCode) {
                    case 2:
                        MVCAdmin.poruke.podaciSuSacuvani();
                        commit(true);
                        break;
                    case 3:
                        MVCAdmin.poruke.podaciNisuValidni();
                        commit(false);
                        break;
                default:
                }
            }
        });
    };
};

MVCAdmin.Pages.Korisnici = new MVCAdmin.Pages.Korisnici();