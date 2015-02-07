//Write a JavaScript function replaceSpaces(value)
// that replaces the white-space characters in a text with &nbsp;. Write JS program spaceReplacer.js

function replaceSpaces(input) {
    var result = input.split(/\s/).join("");
    return result;
}

console.log(replaceSpaces("But you were living in another world tryin\' to get your message through."));
