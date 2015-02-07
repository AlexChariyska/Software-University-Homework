
function circleArea () {
    var radius = document.getElementById('radius').value;
    var area=Math.PI*radius*radius;
    document.body.innerHTML += "r = " + radius + "; area = " + area + "<br/>";
}