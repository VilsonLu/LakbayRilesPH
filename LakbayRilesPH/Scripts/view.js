var flag = true;

function color(north, south){
    if (north == "red" && south == "red") {
        return "-1px";
    } else if (north == "red" && south == "green") {
        return "-25px";
    } else if (north == "red" && south == "yellow") {
        return "-49px";
    } else if (north == "red" && south == "yellow") {
        return "-49px";
    } else if (north == "green" && south == "green") {
        return "-73px";
    } else if (north == "green" && south == "yellow") {
        return "-97px";
    } else if (north == "green" && south == "red") {
        return "-121px";
    } else if (north == "yellow" && south == "yellow") {
        return "-145px";
    } else if (north == "yellow" && south == "green") {
        return "-169px";
    } else if (north == "yellow" && south == "red") {
        return "-192px";
    }
}
$(document).ready(function () {
    var x = color("yellow", "red");
    alert('-23px ' + x);
    $("a").get(0).css({ 'background-position': '-23px ' + x  });




});