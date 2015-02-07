var func = function(){
    var i;

console.log("Number of items: " + arguments.length);

    for (i = 0; i < arguments.length; i += 1) {
        console.log("Item: " + arguments[i] +" Type of: " +typeof(arguments[i]));
    }

    console.log("this.test: " + this.example);
}

func.call("pesho",5,4,"gosho");

console.log();

func.call({example: 'function scope of this'}, 1234, 5664);

console.log();
example = 'global scope of this';
func.apply(null, [1234, 455,"adss"]);