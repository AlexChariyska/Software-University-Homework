/*Write a JavaScript function findMinAndMax(value) that accepts as
parameter an array of numbers. The function finds the minimum and the maximum number*/

function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1;
}
function findMinAndMax(input) {
    input = input.sort(orderBy);
    return 'Min value -> ' + input[0] + "\n" + 'Max value -> ' + input[input.length - 1]+ "\n";
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));