//Write a JavaScript function reverseString(value) that reverses string and returns it

function reverseString(str) {
    var result=str.charAt(str.length - 1);
    for (var i = str.length - 2; i >= 0; i--) {
        result = result.concat(str.charAt(i));
    }
    return result;
}

console.log(reverseString('sample'));
console.log(reverseString('java script'));
console.log(reverseString('softUni'));