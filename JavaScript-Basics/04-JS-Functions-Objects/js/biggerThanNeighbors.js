/*
Write a JavaScript function biggerThanNeighbors(index,  arr) that accept a number and an integer array as parameters.
The function should return a Boolean number: whether the element at the given position
in the array is bigger than its two neighbors (when such exist). It should return undefined when the index doesn't exist. */

function biggerThanNeighbors(index, arr){
    if ((arr[index] > arr[index+1]) && (index===0)){
        console.log('bigger');
    }else if ((arr[index] > arr[index-1]) && (index===arr.length-1)){
        console.log('bigger');
    } else if (arr[index] >= arr.length || arr[index] < 0 ){
        console.log('invalid index');
    }else if ((arr[index] > arr[index-1]) || (arr[index]>arr[index+1])  || index===0 || (index===arr.length-1)) {
        console.log('only one neighbor');
    } else  if((arr[index] > arr[index-1]) && (arr[index]>arr[index+1])) {
        console.log('bigger');
    } else if((arr[index] = arr[index-1]) || (arr[index]=arr[index+1])) {
        console.log('not bigger');
    }
}
biggerThanNeighbors(2, [1, 2, 3, 3, 5]);
biggerThanNeighbors(0, [1, 2, 3, 3, 5]);
