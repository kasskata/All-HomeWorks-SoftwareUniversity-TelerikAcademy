Object.prototype.inherits = function inherits(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}

var Segment = (function () {

    function Segment(point, colorHex, pointB) {
        Shape.apply(this, arguments);
        this.setPointB(pointB);
    }

    Segment.inherits(Shape);

    Segment.prototype.getPointB = function () {
        return this._pointB;
    }

    Segment.prototype.setPointB = function (pointB) {
        this._pointB = pointB;
    }

    Segment.prototype.toString = function () {
        return this.constructor.name + " PointB = "+this._pointB;
    }

    return Segment;

}());