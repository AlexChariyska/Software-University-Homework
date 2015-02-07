/**
 * Write a JavaScript function findNthDigit(arr) that accepts as a parameter an array of two numbers num and n and returns
 * the n-th digit of given decimal number num counted from right to left. Return undefined when the number does not have n-th digit.
 */
function findNthDigit(arr){
    var n =arr[0];
    var number=Math.abs(arr[1])+'';
    var numStr=number.split('.').join('');
    if(numStr[n]){
        console.log(numStr[n]);
    }else {
        console.log("The number doesn't have "+n + " digits.");
    }
}
findNthDigit([5,21.3]);