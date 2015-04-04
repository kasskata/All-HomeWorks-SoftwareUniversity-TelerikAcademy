Object.prototype.inherits = function inherits(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}

var Circle = (function () {

    function Circle(point, colorHex, radius) {
        Shape.apply(this, arguments);
        this.setPoint(point);
        this.setRadius(radius);
    }

    Circle.inherits(Shape);

    Circle.prototype.getPoint = function () {
        return this._point;
    }

    Circle.prototype.setPoint = function (point) {
        this._point = point;
    }

    Circle.prototype.getRadius = function () {
        return this._radius;
    }

    Circle.prototype.setRadius = function (radius) {
        this._radius = radius;
    }

    Circle.prototype.toString = function () {
        return Shape.prototype.toString.call(this) + " Radius = " + this.getRadius();
    }

    return Circle;
}());
