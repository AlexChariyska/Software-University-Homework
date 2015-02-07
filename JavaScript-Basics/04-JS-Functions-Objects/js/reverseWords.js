/**
 * Write a JavaScript function reverseWordsInString(str) to reverse the characters of
 * every word in the string but leaves the words in the same order. Words are considered
 * to be sequences of characters separated by spaces.
 */

function reverseWordsInString(str) {
    var words = str.split(' ');
    var result = [];
    for (var i = 0; i < words.length; i++) {
        var word = words[i];
        var reversed = '';
        for (var j = word.length - 1; j >= 0; j--) {
            reversed += word[j];
        }
        result.push(reversed);
    }
    result=result.join(" ");
    console.log(result);

}
reverseWordsInString('Life is pretty good, isn’t it?');
reverseWordsInString('Hello, how are you.');