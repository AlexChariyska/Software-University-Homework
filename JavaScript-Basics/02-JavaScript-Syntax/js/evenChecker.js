//Write a JavaScript function evenNumber(value) that checks if an integer number is even. Write JS program evenChecker.js to check if a few numbers are even. The result should be printed on the console (true or false).

function evenNumber(number) {
    if (isNaN(number)) {
        console.log('NaN');
    } else {
        if (number % 2 === 0) {
            console.log(true);
        } else if (number % 2 !== 0) {
            console.log(false);
        }
    }
}
evenNumber(3);
evenNumber(127);
evenNumber(128);
evenNumber('str');