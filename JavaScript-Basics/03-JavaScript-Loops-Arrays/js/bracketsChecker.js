//Write a JavaScript function checkBrackets(value) to check if in a given expression the brackets are put correctly.

function checkBrackets(input) {
    var brackets = 0;

    for (var symbol in input) {
        if (input.indexOf(')') < input.indexOf('(')) {
            brackets=1;
            break;
            if (input[symbol] == '(') {
                brackets++;
            }
            else if (input[symbol] == ')') {
                brackets--;
            }
            if (brackets < 0) {
                break;
            }
        }
    }

    if (brackets == 0) {
        return "correct";
    }
    else {
        return "incorrect";
    }
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));
console.log(checkBrackets(') ( a + b ) )'));