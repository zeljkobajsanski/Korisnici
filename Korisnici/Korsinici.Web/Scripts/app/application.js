window.MVCAdmin = {
    defaultTheme: 'metro',
    defaultHeight: 24,
    gridFullWidth: 1014,
    Pages: {
        
    },
    error: function(message) {
        toastr.error(message, 'MVC Admin - Greška', { positionClass: 'toast-bottom-right' });
    },
    success: function (message) {
        toastr.success(message, 'MVC Admin - Ok', { positionClass: 'toast-bottom-full-width' });
    },
    warning: function (message) {
        toastr.warning(message, 'MVC Admin - Upozorenje', { positionClass: 'toast-bottom-full-width' });
    },
    poruke: {
        podaciSuSacuvani : function() {
            toastr.success('Podaci su sačuvani', 'MVC Admin - Ok', { positionClass: 'toast-bottom-full-width' });
        },
        podaciNisuValidni : function() {
            toastr.warning("Podaci nisu validni", 'MVC Admin - Upozorenje', { positionClass: 'toast-bottom-full-width' });
        }
    },
    init: function () {
        $(function() {
            $("#mainMenu").jqxMenu({theme: MVCAdmin.defaultTheme});
        });
    }
};