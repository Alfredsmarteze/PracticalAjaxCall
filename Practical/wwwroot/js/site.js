// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    //$('.all-products').on("click", function ()
    //{
        
        //if (confirm("You want to get all products?")) {

            $.ajax({
                url: "/api/products/",

                type:'json',

                method: "allproducts",


                success: function (data) {

                    $.each(data, function (){

                        $("#enlist").append('<li>' + data+ '</li>')

                    })

                }

            })
        //}
        

    //}

})
