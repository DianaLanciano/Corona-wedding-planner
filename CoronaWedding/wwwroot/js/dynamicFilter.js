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
                if (response.result === "Redirect") { console.log("Redirect"); window.location.href = (response.url);}
                else { $('#myModal').modal('show');}
            },
            error: function () {
                console.log("Error");
        }

        });
        
    });


    //advanced serach
    $(".advancedSerachLocation").click(function () {
       
        let area = document.getElementById("area").value;
        let city = document.getElementById("city").value;
        let fromPrice = document.getElementById("fromPrice").value;
        let toPrice = document.getElementById("toPrice").value;

        window.location.replace("/Locations/Index?area=" + area + "&city=" +
            city + "&fprice=" + fromPrice + "&tprice=" + toPrice + "&filtered=true");
    });
    
    $(".advancedSerachCatering").click(function () {
        let type = document.getElementById("foodType").value;
        let isKosher = document.getElementById("Kosher").value;
        let fromPrice = document.getElementById("fromPrice").value;
        let toPrice = document.getElementById("toPrice").value;
        
        window.location.replace("/Caterings/Index?foodType=" + type +
            "&kosher=" + isKosher + "&fprice=" + fromPrice +
            "&tprice=" + toPrice + "&filtered=true");
    });







});
 