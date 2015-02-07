//Write a JavaScript function calcCylinderVol(value) that accepts the following parameters:
// radius and the height of a straight circular cylinder. The function calculates the volume of the cylinder.
// Write JS program cylinderVol.js that calculates the volume of a few cylinders.

function calcCylinderVol(radius, height ) {
    var volume = (Math.PI * Math.pow(radius,2) * height).toFixed(3);
    console.log(volume);
}
calcCylinderVol(2, 4);
calcCylinderVol(5, 8);
calcCylinderVol(12, 3);
