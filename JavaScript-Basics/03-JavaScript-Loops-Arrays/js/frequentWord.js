/*
 Write a JavaScript function findMostFreqWord(value) that finds the most frequent
 word in a text and prints it, as well as how many times it appears in format "word -> count".
 Consider any non-letter character as a word separator. Ignore the character casing.
 If several words have the same maximal frequency, print all of them in alphabetical order
 Write JS program frequentWord.js that invokes your function with the sample input data
 below and prints the output at the console.
 */

function findMostFreqWord(text) {
    var arr = text.split(/[^a-zA-Z]+/);
    arr=arr.filter(Boolean).sort();

    var maxTimes=0;
    var values=[];

    for (var i = 0; i < arr.length; i++) {
        var word=arr[i];
        var test = new RegExp('(^|\\s)' + word + '(\\s|)', 'gi');
        var res = text.match(test);
        var count=res.length;
        if (values[word] === undefined) {
            values[word] = { word: word, times: count };
        }
        if (values[word].times >= maxTimes) {
            maxTimes = values[word].times;
        }
    }
    for (var i in values) {
        if (values[i].times === maxTimes) {
            console.log(values[i].word + " -> " + values[i].times + " times");
        }
    }
    console.log();
}
findMostFreqWord('in the middle of the night');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');


