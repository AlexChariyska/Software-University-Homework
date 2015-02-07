//Write a JavaScript function soothsayer(value) that accepts the following parameters
// (source arrays): array of numbers, array of programming languages, array of cities,
// array of cars. Each array must consist of five elements. The function must return an array result[]
// that consists of one random item from each source array. Write a JS program that prints on the console
// the following output: “You will work result[0] years on result[1]. You will live in result[2] and drive result[3].”.
// Run the program through Node.js.


    function soothsayer(work, language, city, car) {
    var result = [];
    result[0] = work[Math.floor(Math.random() * work.length)];
    result[1] = language[Math.floor(Math.random() * language.length)];
    result[2] = city[Math.floor(Math.random() * city.length)];
    result[3] = car[Math.floor(Math.random() * car.length)];
    console.log("You will work " + result[0] + " years on " + result[1] + ". You will live in " + result[2] + " and drive " + result[3]);

}
soothsayer([3, 5, 2, 7, 9], ["Java", "Python", "C#", "JavaScript", "Ruby"],["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"], ["BMW", "Audi", "Lada", "Skoda", "Opel"]);