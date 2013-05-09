MVCAdmin.Pages.MojProfil = function() {

    var self = this,
        korisnickoIme,
        ime,
        prezime,
        email,
        btnSacuvaj,
        novaLozinka,
        potvrdaLozinke,
        btnPromeniLozinku;

    $(function() {

        korisnickoIme = $("#KorisnickoIme");
        ime = $("#Ime");
        prezime = $("#Prezime");
        email = $("#EMail");
        btnSacuvaj = $("#btnSubmit");
        novaLozinka = $("#novaLozinka");
        potvrdaLozinke = $("#potvrdaLozinke");
        btnPromeniLozinku = $("#btnPromeniLozinku");

        korisnickoIme.jqxInput({ theme: MVCAdmin.defaultTheme, disabled: true });
        ime.jqxInput({ theme: MVCAdmin.defaultTheme });
        prezime.jqxInput({ theme: MVCAdmin.defaultTheme });
        email.jqxInput({ theme: MVCAdmin.defaultTheme });
        btnSacuvaj.jqxButton({ theme: MVCAdmin.defaultTheme });
        var profileForm = $("form#profile");
        profileForm.jqxValidator({
            hintType: 'label',
            rules: [
                { input: "#KorisnickoIme", message: 'Unesite korisničko ime', rule: 'required' },
                { input: "#Ime", message: 'Unesite ime', rule: 'required' },
                { input: "#Prezime", message: 'Unesite prezime', rule: 'required' },
                { input: "#EMail", message: 'Unesite e-mail', rule: 'required' },
                { input: "#EMail", message: 'Pogrešan e-mail', rule: 'email' }
            ]
        });
        profileForm.submit(function() {
            return profileForm.jqxValidator('validate');
        });
        
        novaLozinka.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'Nova lozinka' });
        potvrdaLozinke.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'Potvrdite lozinku' });
        btnPromeniLozinku.jqxButton({ theme: MVCAdmin.defaultTheme });

        var lozinkaForm = $("form#lozinkaForm");
        lozinkaForm.jqxValidator({
            hintType: 'label',
            rules: [
                { input: "#novaLozinka", message: 'Unesite novu lozinku', rule: 'required' },
                { input: "#potvrdaLozinke", message: 'Unesite potvrdu lozinke', rule: 'required' },
                { input: "#potvrdaLozinke", message: 'Nova lozinka i potvrda se ne slažu', rule: function() {
                    return novaLozinka.val() === potvrdaLozinke.val();
                } }
            ]
        });

        lozinkaForm.submit(function () {
            return lozinkaForm.jqxValidator('validate');
        });


        $("#profileData").jqxExpander({theme: MVCAdmin.defaultTheme});
        $("#lozinkaData").jqxExpander({ theme: MVCAdmin.defaultTheme });
        
    });
};

MVCAdmin.Pages.MojProfil = new MVCAdmin.Pages.MojProfil();