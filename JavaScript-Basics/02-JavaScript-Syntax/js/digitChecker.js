//Write a JavaScript function checkDigit(value) that finds if the third digit
// (right-to-left) of an integer number n (n>1000) is 3. Write JS program digitChecker.js
// that checks a few numbers. The result (true or false) should be printed on the console.

    function checkDigit(number) {
   number= Math.floor(number/100);
    if (number % 10 === 3) {
        console.log('true')
    } else {
        console.log(false);
    }
}
checkDigit(1235);
checkDigit(25386);
checkDigit(123456);
checkDigit(1200300);