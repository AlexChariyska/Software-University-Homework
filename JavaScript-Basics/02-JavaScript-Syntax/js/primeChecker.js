//Write a JavaScript function isPrime(value) that checks if an integer number is prime. Write JS program primeChecker.js
// that checks if a few numbers are prime.
// The result should be printed on the console (true or false) on the console.

    function isPrime(number){
    var divider = 2;
    var maxDivider = Math.sqrt(number);
    var prime = true;
    while (prime && (divider <= maxDivider)) {
        if (number % divider == 0) {
            prime = false;
        }
        divider++;
    }
    console.log(prime);
}
isPrime(7);
isPrime(254);
isPrime(587);