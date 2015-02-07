//Write a JavaScript function calcSupply(value) that accepts the following parameters:
// your age, your maximum age, estimate amount of your favorite food per day (as a number).
// The function calculates how many of the food you will eat for the rest of your life. Write JS program
// lifetimeSupplyCalc.js that calculates the amount of a few foods that you will eat. The result should be
// printed on the console.

    function calcSupply(age, maxAge,foodPerDay, strFood){
var food=(maxAge-age)*foodPerDay*365;
    console.log(food+'kg of '+ strFood+' would be enough until I am ' + maxAge+ ' years old.');return(food);
}
calcSupply(38, 118, 0.5, 'chocolade');
calcSupply(20, 87, 2, 'fruits');
calcSupply(16, 102, 1.1, 'nuts');
