var Shape = (function () {

    function Shape(point, colorHex) {
        this.setPoint(point);
        this.setColor(colorHex);
    }

    Shape.prototype.getPoint = function () {
        return this._point;
    }

    Shape.prototype.setPoint = function (point) {
        this._point = point;
    }

    Shape.prototype.getColor = function () {
        return this._colorHex;
    }

    Shape.prototype.setColor = function (colorHex) {
        this._colorHex = colorHex;
    }

    Shape.prototype.toString = function () {
        return this.constructor.name + this._point.toString() + ' Color = ' + this.getColor();
    }

    return Shape;
}());
