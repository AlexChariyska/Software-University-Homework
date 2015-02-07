/*Write a JavaScript function createArray(value) that allocates array of 20 integers and initializes each element by its index multiplied by 5.*/

function createArray(){
var arr= new Array(20);
    for (var i=0; i<20; i++){
        arr[i]=i*5;
    }
    return arr;
}
console.log(createArray());