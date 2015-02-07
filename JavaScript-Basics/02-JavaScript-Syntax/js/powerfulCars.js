//Write a JavaScript function convertKWtoHP(value) to convert car’s kW into hp (horse power).The result should be printed on the console, rounded up to the second sign after the decimal point.

function convertKWtoHP(hp){
var kW=(hp/0.745699872).toFixed(2);
    console.log('Kw= '+ kW);
}
convertKWtoHP(75);
convertKWtoHP(150);
convertKWtoHP(1000);