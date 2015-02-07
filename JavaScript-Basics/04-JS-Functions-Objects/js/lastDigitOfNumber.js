/*Write a JavaScript function lastDigitAsText(number) that returns the last digit of given integer as an English word. */

function lastDigitAsText(number) {
    if (typeof (number) != "number") {
        console.log('Not a number');
    } else {
        var num = Math.abs(number) + '';
        switch (num[num.length - 1]) {
            case '1':
                console.log("one");
                break;
            case '2':
                console.log("two");
                break;
            case '3':
                console.log("three");
                break;
            case '4':
                console.log("four");
                break;
            case '5':
                console.log("five");
                break;
            case '6':
                console.log("six");
                break;
            case '7':
                console.log("seven");
                break;
            case '8':
                console.log("eight");
                break;
            case '9':
                console.log("nine");
                break;
            case '0':
                console.log("zero");
                break;
        }
    }
}
lastDigitAsText(-89);