/**
 * Write a JavaScript function findYoungestPerson(persons) that accepts as parameter an array of persons,
 * finds the youngest person and returns his full name.
 */
function findYoungestPerson(persons) {
    var minAge = persons[0];
    for (var i = 1; i < persons.length; i++) {
        var objCurr = persons[i];
        if (minAge.age > objCurr.age) {
            minAge = objCurr;
        }
    }
    console.log('The youngest person is '+ minAge.firstname +' '+minAge.lastname+'.');
}
var persons = [
    { firstname: 'George', lastname: 'Kolev', age: 32},
    { firstname: 'Bay', lastname: 'Ivan', age: 81},
    { firstname: 'Baba', lastname: 'Ginka', age: 60}
];
findYoungestPerson(persons);