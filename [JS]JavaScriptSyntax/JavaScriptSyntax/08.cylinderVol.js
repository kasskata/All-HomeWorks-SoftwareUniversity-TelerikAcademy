"use strict";

console.log(calcCylinderVol(2, 4));

function calcCylinderVol(radius , height){
    //Pi*r^2 * h

    return Math.PI*(radius*radius)*height;
}