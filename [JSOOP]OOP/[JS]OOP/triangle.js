Object.prototype.inherits = function inherits(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}

var Triangle = (function () {

    function Triangle(point, colorHex, pointB, pointC) {
        Shape.apply(this, arguments);
        this.setPointB(pointB);
        this.setPointC(pointC);
    }

    Triangle.inherits(Shape);

    Triangle.prototype.getPointB = function () {
        return this._pointB;
    }

    Triangle.prototype.setPointB = function (pointB) {
        this._pointB = pointB;
    }

    Triangle.prototype.getPointC = function () {
        return this._pointC;
    }

    Triangle.prototype.setPointC = function (pointC) {
        this._pointC = pointC;
    }

    return Triangle;
}());