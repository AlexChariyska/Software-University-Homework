//Write a JavaScript function convertDigitToWord(value) that prints the
// name of an integer number n (0<n<10) in English using switch statement.
// Write JS program digitAsWord.js that prints a few digits on the console. Run the program through Node.js

function digitAsWord(digit) {
    switch (digit) {
        case 1:
            console.log('one');
            break;
        case 2:
            console.log('two');
            break;
        case 3:
            console.log('three');
            break;
        case 4:
            console.log('four');
            break;
        case 5:
            console.log('five');
            break;
        case 6:
            console.log('six');
            break;
        case 7:
            console.log('seven');
            break;
        case 8:
            console.log('eight');
            break;
        case 9:
            console.log('nine');
            break;
        default:
            console.log('Not a digit');
            break;
    }
}
digitAsWord(3);
digitAsWord(9);
digitAsWord(45);