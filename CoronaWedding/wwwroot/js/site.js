$(document).ready(function () {

    $("#logo").click(function () {
        location.href = "/Home"
    });

    $("#startProcess").click(function () {
        window.location.assign("Accounts/Login");
    });

    $("#btn-search").click(function (event) {
        event.preventDefault();
        event.stopPropagation();

        var searchTerm = document.getElementById("searchBox").value;
        window.location.href = "/Accounts/Dashboard?term=" + searchTerm;
    });
});

