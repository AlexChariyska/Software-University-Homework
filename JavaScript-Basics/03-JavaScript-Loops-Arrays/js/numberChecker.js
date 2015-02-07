//Write a JavaScript function printNumbers(n) that accepts as parameter integer n.
// The function finds all integer numbers from 1 to n that are not divisible by 4 or by 5.

function printNumbers(n) {
    if (n > 0) {
        var result=1;
        for (var i = 2; i <= 20; i++) {
            if (i % 4 !== 0 && i % 5 !== 0) {
                result = result + " " + i;
            } else {
                continue;
            }
        }
        return result;
    }
    else {
            return 'no';
        }
    }


console.log(printNumbers(20));
console.log(printNumbers(-5));
console.log(printNumbers(13));