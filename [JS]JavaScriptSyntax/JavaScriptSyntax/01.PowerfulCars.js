 console.log(convertKWtoHP(150).toFixed(2));

function convertKWtoHP(value){
    var kW = value;
    var hP = 1.34102209;

    return hP*kW;
}