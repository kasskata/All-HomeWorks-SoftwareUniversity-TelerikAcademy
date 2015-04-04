"use strict";

displayProperties()

function displayProperties() {
    var properties = [];
    for (var prop in document) {
        properties.push(prop);
    }

    properties.sort();

    console.log(properties);

    //NOTE: If you are using the normal console - <br> must be replaces by /n as a separator

}