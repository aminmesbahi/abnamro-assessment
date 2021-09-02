(function() {
    'use strict'

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.querySelectorAll('.needs-validation')
        /////
    $("#requestValue").on('keyup', function(event) {
        ///
        Array.prototype.slice.call(forms)
            .forEach(function(form) {
                if (!form.checkValidity()) {
                    event.preventDefault();
                    event.stopPropagation();
                    $("#btnStartCalculation").attr("disabled", 'disabled');
                    $("#requestValueHelpBlockText").removeClass("text-muted");
                    $("#requestValueHelpBlockText").removeClass("text-success");
                    $("#requestValueHelpBlockText").addClass("text-danger");
                }
                if (form.checkValidity()) {
                    $("#btnStartCalculation").removeAttr('disabled');
                    $("#requestValueHelpBlockText").addClass("text-success");
                    $("#requestValueHelpBlockText").removeClass("text-danger");
                }
                form.classList.add('was-validated')
            }, false);

        ///
        let current = $(this).val();
        let min = parseInt($(this).attr("min"));
        let max = parseInt($(this).attr("max"));
        if (current > min && current <= max) {
            $(this).parent("#requestValue").addClass("valid").removeClass("invalid");
            $(this).addClass("valid").removeClass("invalid");
        } else {
            $(this).parent("#requestValue").addClass("invalid").removeClass("valid");
            $(this).addClass("invalid").removeClass("valid");
        }
    });
    /////
    // Loop over them and prevent submission
    Array.prototype.slice.call(forms)
        .forEach(function(form) {
            form.addEventListener('submit', function(event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }
                form.classList.add('was-validated')
            }, false)
        })
        //

})()