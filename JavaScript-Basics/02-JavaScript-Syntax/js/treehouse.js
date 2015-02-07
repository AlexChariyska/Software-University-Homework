//Write a JavaScript function treeHouseCompare(value) that accepts the following parameters:
// integers a and b. The function compares the area of the house and the area of the tree (Figure 1)
// and returns the name of the figure with bigger area (house or tree) and the value of the area.
// Write JS program treehouse.js that compares a few houses and trees. The result should be printed on the console.

    function treeHouseCompare(a, b) {
    var houseArea = (a * a) + (a * 2 / 3 * a) / 2;
    var treeArea = (b * 1 / 3 * b) + (Math.PI * Math.pow((2 / 3 * b), 2));
    if (houseArea > treeArea) {
        console.log("house/" + houseArea.toFixed(2));
    }
    else if (houseArea === treeArea) {
        console.log("equal/" + houseArea.toFixed(2));
    }
    else {
        console.log("tree/" + treeArea.toFixed(2));
    }
}

treeHouseCompare(3, 2);
treeHouseCompare(3, 3);
treeHouseCompare(4, 5);