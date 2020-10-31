$(document).ready(function () {

    $(".filterButton").click(function () {
        //for filtering
        var valueForSearch = $(this).val();
        var model = $(this).attr("name");
        window.location.replace("/" + model + "/Index/" + valueForSearch);
    });


    //for mooving to Detils page
    $(".imageFilter").click(function () {
        var idToDetails = $(this).attr("id");
        var controller = $(this).attr("name");
        window.location.replace("/" + controller + "/Details/" + idToDetails);
    });


});
 