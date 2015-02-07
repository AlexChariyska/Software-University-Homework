//Sorting an array means to arrange its elements in increasing order. Write
// a JavaScript function sortArray(value) to sort an array. Use the "selection sort"
// algorithm: find the smallest element, move it at the first position, find the smallest
// from the rest, move it at the second position, etc. Write JS program arraySorter.js that invokes
// your function with the sample input data below and prints the output at the console. Use a second array.

function sortArray(arr) {
    result = arr.sort(orderBy);
    return result;
}
function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1;
}
console.log(sortArray([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));