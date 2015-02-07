/*
 Write a JavaScript function findCardFrequency(value)  that accepts the following parameters:
 array of several cards (face + suit), separated by a space. The function calculates and prints
 at the console the frequency of each card face in format "card_face -> frequency". The frequency is
 calculated by the formula appearances / N and is expressed in percentages with exactly 2 digits after
 the decimal point. The card faces with their frequency should be printed in the order of the card face's ' +
 'first appearance in the input. The same card can appear multiple times in the input, but its face should' +
 ' be listed only once in the output. */

function findCardFrequency(input) {
    var arr = [];
    var values = {};
    var count = 0;
    var freq = 1;
    arr = input.split(/[♣♦♥♠ ]+/).filter(Boolean);
    for (var i = 0; i < arr.length; i++) {
        for (var k = 0; k < arr.length; k++) {
            if (arr[i] === arr[k]) {
                count++;
            }
        }
        freq = ((count / arr.length) * 100).toFixed(2);
        var card = arr[i];
        if (values[card] === undefined) {
            values[card] = { card: card, times: freq };
            console.log(values[card].card +' -> '+ values[card].times+ '%');
        }
        count = 0;
    }
    console.log();
}
findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♥ 10♣');