Object.prototype.inherits = function inherits(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}

var Rectangle = (function () {

    function Rectangle(point, colorHex, width, height) {
        Shape.apply(this, arguments);
        this.setWidth(width);
        this.setHeight(height);
    }

    Rectangle.inherits(Shape);

    Rectangle.prototype.getWidth = function () {
        return this._width;
    }

    Rectangle.prototype.setWidth = function (width) {
        this._width = width;
    }

    Rectangle.prototype.getHeight = function () {
        return this._height;
    }

    Rectangle.prototype.setHeight = function (height) {
        this._height = height;
    }

    Rectangle.prototype.toString = function () {
        return Shape.prototype.toString.call(this) + " Width = " + this.getWidth() + " Height = " + this.getHeight();
    }

    return Rectangle;
}());