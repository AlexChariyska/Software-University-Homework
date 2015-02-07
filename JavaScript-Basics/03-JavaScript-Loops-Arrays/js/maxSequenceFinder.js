//Write a JavaScript function findMaxSequence(value) that finds the maximal increasing sequence
// in an array of numbers and returns the result as an array. If there is no increasing sequence
// the function returns 'no'.
// Write JS program maxSequenceFinder.js that invokes your function with the sample input data

function findMaxSequence(arr) {
    var count=1;
    var maxCount=0;
    var position=0;
    var result=new Array();
    for (var i=1; i<arr.length;i++){
        if(arr[i-1]<arr[i]){
            count++;
            if(count>=maxCount){
                maxCount=count;
                position=i;
            }
        }else{
            count=0;
        }
    }
    for(var k=0; k<=maxCount;k++){
       result[maxCount-k]=arr[position-k];
    }
    if (result>arr[1] || arr.length==1){
        result='no';
    }
    return result;
}

console.log( findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log( findMaxSequence([3, 2, 1]));
console.log( findMaxSequence([3]));
console.log( findMaxSequence([3, 2, 3, 4, 2, 2, 4]));