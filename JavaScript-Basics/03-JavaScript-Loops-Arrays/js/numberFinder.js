//Write a JavaScript function findMostFreqNum(value) that finds the most frequent
// number in an array. If multiple numbers appear the same maximal number of times,
// print the leftmost of them.

function findMostFreqNum(arr) {
    var count = 1;
    var maxCount = 0;
    var number = 0;
    for (var i = 0; i < arr.length - 1; i++) {
        for (var k = 1; k < arr.length; k++) {
            if (arr[i] === arr[k]) {
                count++;
            }
        }
        if (count > maxCount) {
            maxCount = count;
            number = arr[i];
        }
        count=0;
    }
    return number + "( " + maxCount + " times )";

}

console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
