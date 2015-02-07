/*Write a JavaScript function displayProperties(value) that displays all the properties of the "document" object in alphabetical order*/

function displayProperties() {
    var result=[];
    Object.getOwnPropertyNames(window.document).forEach(function(a) {
        result.push(a);
    });
    result.sort();
    for (var res in result) {
        console.log(result[res])
    }
}

displayProperties();