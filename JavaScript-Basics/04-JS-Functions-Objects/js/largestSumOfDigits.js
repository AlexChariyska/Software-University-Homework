/**
 * Write a JavaScript function findLargestBySumOfDigits(nums) that takes as an input a sequence of positive
 * integer numbers and returns the element with the largest sum of its digits. The function should take a
 * variable number of arguments. It should return undefined when 0 arguments are passed or when some of the
 * arguments is not an integer number.
 */
function findLargestBySumOfDigits(nums) {
    if (nums.length === 0) {
        console.log('undefined');
    } else {
        var sum = 0;
        var maxSum = 0;
        var number;
        var check = true;
        for (var i = 0; i < nums.length; i++) {
            var numStr = num + '';
            var num = Math.abs(nums[i]);
            if (typeof(num) !== 'number' || (num % 1 !== 0)) {
                check = false;
                break;
            } else {
                for (var j = 0; j < numStr.length; j++) {
                    sum += Number(numStr[j]);
                }
                if (sum > maxSum) {
                    maxSum = sum;
                    number = numStr;
                }
                sum = 0;
            }
        }
        if (check === true) {
            console.log(number);
        }else {
            console.log('undefined');
        }
    }

}
findLargestBySumOfDigits([33, 44, -99, 0, 20]);
findLargestBySumOfDigits([5, 3.3]);