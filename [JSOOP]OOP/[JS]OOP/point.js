var Point = (function () {

    function Point(x, y) {
        this.setX(x);
        this.setY(y);
    }

    Point.prototype.getX = function () {
        return this._x;
    }

    Point.prototype.setX = function (x) {
        this._x = x;
    }

    Point.prototype.getY = function () {
        return this._y;
    }

    Point.prototype.setY = function (y) {
        this._y = y;
    }

    Point.prototype.toString = function () {
        return ' X = ' + this._x + ' Y = ' + this._y;
    }

    return Point;
}());