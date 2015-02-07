//Write a JavaScript function findMaxSequence(value) that finds the maximal
// sequence of equal elements in an array and returns the result as an array.
// If there is more than one sequence with the same maximal length, print the rightmost one.

    function findMaxSequence(arr) {
    var count = 1;
    var str=arr[0];
    var maxCount = 0;
    var result = new Array();
    for (var i = 1; i < arr.length; i++) {
        if (arr[i - 1] === arr[i]) {
            count++;
            if (count >= maxCount) {
                maxCount = count;
                str = arr[i];
            }
        } else {
            count = 0;
        }
    }
    for (var a = 0; a <= maxCount; a++)
        result[a] = str;
    return result;
}
console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));
console.log(findMaxSequence(['happy']));