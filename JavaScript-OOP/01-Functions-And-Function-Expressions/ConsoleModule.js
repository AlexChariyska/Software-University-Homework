var specialConsole = function () {

    function printString() {
        var result = '';

        if (arguments[1] == null) {
            result = arguments[0];
        } else {
            result = printing(arguments);
        }

        return result;
    }


    function printing(arguments) {

        var result = arguments[0];
        var i;

        for (i = 0; i < arguments.length; i++) {
            var toBeReplaced = "{" + i + "}";
            result = result.replace(toBeReplaced, arguments[i + 1]);
        }

        return(result);
    }


    function writeLine() {
        console.log(printing(arguments))
    }

    function writeError() {
        console.error(printing(arguments))
    }

    function writeWarning(msg) {
        console.warn(printing(arguments))
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    }

}();
specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");

