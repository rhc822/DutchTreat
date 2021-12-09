var x = 0;
var s = "";

console.log("Hi");

var theForm = document.getElementById("theForm");
theForm.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    console.log("Buying Item");
});

var productInfo = document.getElementsByClassName("product-props");
var li = document.getElementsByTagName("li");
var listItems = li.item(3).children;
console.log(listItems);
//var listItems = console.log(typeof productInfo.item)
