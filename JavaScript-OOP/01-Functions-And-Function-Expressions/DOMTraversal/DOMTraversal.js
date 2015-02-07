function traverse(selector) {

    var element = document.querySelector(selector);

    if (element !== undefined && element !== null) {
        traverseNode(element, '');
    }

    function traverseNode(element, spacing) {
        var nodeId = element.getAttribute('id');
        var nodeClass = element.getAttribute('class');
        var nodeNameLower =element.nodeName.toLowerCase();

        spacing = spacing || '  ';
        console.log(spacing + nodeNameLower + ':'
            + (nodeId ? ' id="' + nodeId + '"' : '')
            + (nodeClass ? ' class="' + nodeClass + '"' : ''));

        for (var i = 0; i < element.childNodes.length; i++) {
            var child = element.childNodes[i];
            if (child.nodeType === document.ELEMENT_NODE) {
                traverseNode(child, spacing + '  ');
            }
        }
    }
}

traverse(".birds");
