/*Write a JavaScript function findPalindromes(value) that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

function findPalindromes(text) {
    var normalArr = text.toLowerCase().split(/\W/);
    var reversedArr=[];
    var reversedStr;
    for (var i = 0; i < normalArr.length; i++) {
        var word = normalArr[i];
        if (word!=='') {
            reversedStr=word.split('').reverse().join('');
            if (reversedStr === word) {
                reversedArr.push(word);
            }
        }
    }
    return reversedArr;
}
console.log(findPalindromes('There is a man, his name was Bob'));
console.log(findPalindromes(' a maam cac'));