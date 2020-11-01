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

    $(".addToCartButoon").click(function ()
    {
        var itemType = $(this).attr("name");
        var itemId = $(this).attr("id");
        $.ajax({
            type: "GET",
            url: "/Accounts/addToCart?itemType=" + itemType + "&itemId=" + itemId,
            success: function (response) {
                console.log("ajax works!");
                if (response.result == 'Redirect') {
                    window.location = response.url;
                    alert("Added to cart");
                }
                   
            },
            error: function () {
                console.log("Error");
        }

    });
     
        
    });


});
 