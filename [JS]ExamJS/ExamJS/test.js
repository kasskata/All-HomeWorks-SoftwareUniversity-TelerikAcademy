var elmt = new Array();

elmt[0] = "0";
elmt[1] = "1";
elmt[2] = "2";
elmt[3] = "3";
elmt[4] = "4";
elmt[5] = "7";
elmt[6] = "8";
elmt[7] = "9";
elmt[8] = "10";
elmt[9] = "11";


var sum = 0;
for(var i = 0; i < elmt.length; i++){
    sum += parseInt(elmt[i], 10); //don't forget to add the base
}

var avg = sum/elmt.length;

console.log("The sum of all the elements is: " + sum + " The average is: " + avg);