//Write a JavaScript function bitChecker(value) that finds if the bit 3 an integer
// number (counting from 0) is 1. Write JS program checkingBits.js to check a few numbers.
// The result (true or false) should be printed on the console.

    function bitChecker(number) {
var bitChecker=(number>>3)&1;
    if (bitChecker==1){
        console.log(true);
    } else{
        console.log(false);
    }
}
bitChecker(333);
bitChecker(425);
bitChecker(2567564754);