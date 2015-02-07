var domModule = function () {

    //Adding а DOM element to a parent element specified by selector
    function appendChild(element, selector) {
        var nodeSelected = document.querySelector(selector);
        var element = document.createElement(element);
        nodeSelected.appendChild(element);
    }

    //	Removing a child element from a parent specified by selector
    function removeChild(selector, element) {
        var nodeSelected = document.querySelector(selector);
        var elementToBeRemoved = document.querySelector(element);

        nodeSelected.removeChild(elementToBeRemoved);
    }

    //	Retrieving elements by a given CSS selector
    function addHandler(selector, event, action) {
        var element = document.querySelector(selector);
        element.addEventListener(event, action);
    }

    //	Retrieving elements by a given CSS selector
    function retrieveElements(selector) {
        var elements = document.querySelectorAll(selector);

        return elements;
    }

    var self = {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };

    return self;

}();

domModule.addHandler("li", 'click', function () {
    alert("I'm a bird!");
});
var elements = domModule.retrieveElements(".bird");
domModule.appendChild("li",".birds-list");
domModule.removeChild("ul.birds-list","li:first-child");
