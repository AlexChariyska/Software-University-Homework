(function () {

    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../node_modules/underscore/underscore.js');
    }


    var students =[{"gender":"Male","firstName":"Joe","lastName":"Riley","age":22,"country":"Russia"},
        {"gender":"Female","firstName":"Lois","lastName":"Morgan","age":41,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Roy","lastName":"Wood","age":33,"country":"Russia"},
        {"gender":"Female","firstName":"Diana","lastName":"Freeman","age":40,"country":"Argentina"},
        {"gender":"Female","firstName":"Bonnie","lastName":"Hunter","age":23,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Joe","lastName":"Young","age":16,"country":"Bulgaria"},
        {"gender":"Female","firstName":"Kathryn","lastName":"Murray","age":22,"country":"Indonesia"},
        {"gender":"Male","firstName":"Dennis","lastName":"Woods","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Billy","lastName":"Patterson","age":24,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Willie","lastName":"Gray","age":42,"country":"China"},
        {"gender":"Male","firstName":"Justin","lastName":"Lawson","age":38,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Ryan","lastName":"Foster","age":24,"country":"Indonesia"},
        {"gender":"Male","firstName":"Eugene","lastName":"Morris","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Eugene","lastName":"Rivera","age":45,"country":"Philippines"},
        {"gender":"Female","firstName":"Kathleen","lastName":"Hunter","age":28,"country":"Bulgaria"}]

//	Get all students with age between 18 and 24
    var ageSort = _.filter(students, function(student){
        return student.age >=18 && student.age <=24;
    });
   /* console.log(ageSort);*/

// Get all students whose first name is alphabetically before their last name
    var nameSort = _.filter(students, function(student){
        return student.firstName < student.lastName;
    });
   /* console.log(nameSort);*/

//	Get only the names of all students from Bulgaria. Chain - Returns a wrapped object. Calling methods on this object will continue to return wrapped objects until value is called.
    var bulgarians = _.chain(students, function(student){
        _.where( student.country === "Bulgaria")
        _.map( function(student){ return student.firstName + student.lastName;})
            .value();
    });
 /*   console.log(bulgarians);*/

   // Get the last five students
    var lastStudents = _.last(students, 5);
   /* console.log(lastStudents);*/

    //Get the first three students who are not from Bulgaria and are male

    var sorted	= _.chain(students)
        .filter(function(student){
            return student.country !== 'Bulgaria' && student.gender === 'Male';
        }).first(3).value();

    console.log(sorted);
})();