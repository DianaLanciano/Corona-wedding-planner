$(document).ready(function () {

    $("#logo").click(function () {
        location.href = "/Home"
    });
    $("#startProcess").click(function () {
        window.location.assign("Accounts/Login");
    });

    /*Check for Diana*/
    //$("#createUser").click(function () {
    //    $("#login").css("display", "none");
    //    $("#create").css("display", "block");
    //});

    $("#searchBox").autocomplete({
        source: "/Accounts/searchBox",
        minLength: 2,
        select: function (event, ui) {
            location.href = '/Accounts/Details/'+ ui.item.AccoundId;
        }
    });

});
