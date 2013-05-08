MVCAdmin.Pages.Register = function() {

    var self = this,
        korisnickoIme,
        lozinka,
        ime,
        prezime,
        eMail,
        btnSubmit;

    $(function() {
        korisnickoIme = $("#Korisnik_KorisnickoIme");
        korisnickoIme.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'Korisničko ime' });

        lozinka = $("#Korisnik_LozinkaPlain");
        lozinka.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'Lozinka' });
        
        ime = $("#Korisnik_Ime");
        ime.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'Ime' });
        
        prezime = $("#Korisnik_Prezime");
        prezime.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'Prezime' });
        
        eMail = $("#Korisnik_EMail");
        eMail.jqxInput({ theme: MVCAdmin.defaultTheme, placeHolder: 'E-mail' });

        btnSubmit = $("#btnSubmit");
        btnSubmit.jqxButton({ theme: MVCAdmin.defaultTheme });

        var form = $("form");
        form.jqxValidator({hintType: 'label',
            rules: [
                { input: "#Korisnik_KorisnickoIme", message: 'Unesite korisničko ime', rule: 'required' },
                { input: "#Korisnik_LozinkaPlain", message: 'Unesite lozinku', rule: 'required' },
                { input: "#Korisnik_Ime", message: 'Unesite ime', rule: 'required' },
                { input: "#Korisnik_Prezime", message: 'Unesite prezime', rule: 'required' },
                { input: "#Korisnik_EMail", message: 'Unesite e-mail', rule: 'required' },
                { input: "#Korisnik_EMail", message: 'Pogrešan e-mail', rule: 'email' }
            ]
        });
        form.submit(function() {
            return  form.jqxValidator('validate');
        });
    });
};

MVCAdmin.Pages.Register = new MVCAdmin.Pages.Register();