"use strict";

var someParameters = ['Pesho', 22, true, ['fries', 'banana', 'cake']];
variablesTypes(someParameters);
function variablesTypes(someParameters) {
    var variables = {name: someParameters[0],age:someParameters[1], ismale: someParameters[2], favoritefruit:someParameters[3]};

    console.log("My name: "+variables.name);
    console.log("My age:  "+variables.age);
    console.log("I am male: "+variables.ismale);
    console.log("My favorite foods are: "+variables.favoritefruit);
}