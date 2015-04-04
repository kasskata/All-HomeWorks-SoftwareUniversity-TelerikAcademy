// Object.prototype.inherits = function inherits(parent) {
//     this.prototype = Object.create(parent.prototype);
//     this.prototype.constructor = this;
// }

var Potato = (function () {

    function Potato() {
        // .apply(this, arguments);
    }

    // Potato.inherits();

    Potato.prototype.toString = function () {
        return this.constructor.name;
    }

    return Potato;
}());
Object.prototype.isNullOrEmpty = function (value, varName) {
    if (typeof (value) != 'string') {
        throw new Error(varName + " String cannot be null or empty");
    }
    if (!value) {
        throw new Error(varName + "(String) cannot be null or empty");
    }
}

Object.prototype.isIntegerOrInRange = function (value, minValue, maxValue, varName) {
    if (typeof (value) != 'number') {
        throw new Error(varName + " must be Number.");
    }
    if (value === parseInt(value, 10)) {
        throw new Error(varName + " must be Integer.");
    }
    if (value < minValue || value > maxValue) {
        throw new Error(varName + " must be Integer in range[" + minValue + "..." + maxValue + "].");
    }
}