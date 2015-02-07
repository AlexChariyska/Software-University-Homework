var canvasArea = document.getElementById("canvasDiv").getContext("2d");

document.getElementById("remove").addEventListener("click", function () {
    canvasArea.clearRect(0, 0, 500, 400);
    document.getElementById("textResult").innerHTML = "";
    clearInput();
});

function clearInput() {
    var fields = document.getElementsByTagName("INPUT");
    for (var i = 0; i < fields.length; i++) {
        fields[i].value = "";
    }
};

document.getElementById("add").addEventListener("click", function () {
    var x = parseInt(document.getElementById('x').value),
        y = parseInt(document.getElementById('y').value),
        x2 = parseInt(document.getElementById('x2').value),
        y2 = parseInt(document.getElementById('y2').value),
        x3 = parseInt(document.getElementById('x3').value),
        y3 = parseInt(document.getElementById('y3').value),
        radius = parseInt(document.getElementById('radius').value),
        color = document.getElementById('color').value,
        selected = document.getElementById('shape').value,
        textArea = document.getElementById('textResult'),
        shape;

    switch (selected) {
        case 'rectangle':
            var width = document.getElementById('width').value;
            var height = document.getElementById('height').value;

            shape = new Shapes.Rect(x, y, color, width, height);
            textArea.innerHTML += shape.toString() + "\n";
            break;
        case 'triangle':
            shape = new Shapes.Triangle(x, y, color, x2, y2, x3, y3);
            textArea.innerHTML += shape.toString() + "\n";
            break;
        case 'point':
            shape = new Shapes.Point(x, y, color);
            textArea.innerHTML += shape.toString() + "\n";
            break;
        case 'circle':
            shape = new Shapes.Circle(x, y, color, radius);
            textArea.innerHTML += shape.toString() + "\n";
            break;
        case 'segment':
            shape = new Shapes.Segment(x, y, color, x2, y2);
            textArea.innerHTML += shape.toString() + "\n";
            break;
    }
    clearInput();
    return shape.draw();
});



