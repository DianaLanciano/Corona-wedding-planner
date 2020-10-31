$(document).ready(function () {

    $("#logo").click(function () {
        window.location.assign("Home/Index");
    });
    $("#startProcess").click(function () {
        window.location.assign("Accounts/Login");
    });

    /*Check for Diana*/
    //$("#createUser").click(function () {
    //    $("#login").css("display", "none");
    //    $("#create").css("display", "block");
    //});

});
