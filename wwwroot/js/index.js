var x = 0;
var s = "";

console.log("Hi");

// Vanilla JS
/*
var theForm = document.getElementById("theForm");
theForm.hidden = true;
*/

// jQuery

var theForm = $("#theForm");
theForm.hide();


// Vanilla JS
/*
var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    console.log("Buying Item");
});
*/

// jQuery
var button = $("buyButton");
button.on("click", function () {
    console.log("Buying Item");
});

// Vanilla JS
/*
var productInfo = document.getElementsByClassName(".product-props");
var listItems = productInfo.item[0].children;
*/

//jQuery

/*
  jQuery enables full CSS selector syntax in a query(e.g. 'li' in product info below), instead of looping through the object
*/
var productInfo = $(".product-props li");
productInfo.on("click", function () {
    console.log("You clicked on " + $(this).text());
});

