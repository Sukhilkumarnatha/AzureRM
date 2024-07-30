// wwwroot/js/site.js
$(document).ready(function () {
    $("form").submit(function (event) {
        event.preventDefault();

        var name = $("#name").val();
        var email = $("#email").val();
        var message = $("#message").val();

        if (!name || !email || !message) {
            alert("All fields are required.");
            return;
        }

        $.ajax({
            type: "POST",
            url: "/Home/Contact",
            data: {
                name: name,
                email: email,
                message: message
            },
            success: function () {
                alert("Thank you for your message!");
            },
            error: function () {
                alert("An error occurred. Please try again.");
            }
        });
    });
});
