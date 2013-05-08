window.MVCAdmin = {
    defaultTheme: 'metro',
    defaultHeight: 24,
    Pages: {
        
    },
    error: function(message) {
        toastr.error(message, 'MVC Admin - Greška', { positionClass: 'toast-bottom-right' });
    },
    success: function (message) {
        toastr.success(message, 'MVC Admin - Ok', { positionClass: 'toast-bottom-full-width' });
    },
};