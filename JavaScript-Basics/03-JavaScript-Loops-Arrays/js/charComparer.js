//Write a JavaScript function compareChars(value) that compares two arrays of chars lexicographically (letter by letter).

function compareChars(arr, arr2) {
    var firstArr = arr.join("").replace(/\W/g, "");
    var secondArr = arr2.join("").replace(/\W/g, "");

    if(firstArr===secondArr){
       return 'Equal';
    }else{
        return 'Not equal';
    }
}

console.log(compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']));
console.log(compareChars(['3', '5', 'g', 'd'], ['3', '5', 'g', 'd']));
console.log(compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']));

