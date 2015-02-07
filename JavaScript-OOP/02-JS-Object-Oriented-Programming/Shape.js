Object.prototype.extends = function (parent) {
    if (!Object.create) {
        Object.prototype.create = function (proto) {
            function F() {
            };
            F.prototype = proto;
            return new F;
        };
    }
    ;

    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

var Shapes = (function () {
    var Shape = (function () {
        function Shape(x, y, color) {
            this._x = x;
            this._y = y;
            this._color = color;
        }

        Shape.prototype = {
            serialize: function () {
                var serializedShape = {
                    x: this._x,
                    y: this._y,
                    color: this._color
                };

                return serializedShape;
            },
            canvas: function () {
                var canvas = {
                    element: document.getElementById("canvasDiv").getContext("2d")
                };

                return canvas;
            }
        };

        Shape.prototype.toString = function () {
            return this.serialize();
        };

        return Shape;
    }());

    var Circle = (function () {
        function Circle(x, y, color, radius) {
            Shape.call(this, x, y, color);
            this._radius = radius;
        }

        Circle.extends(Shape);

        Circle.prototype.serialize = function () {
            var serializedCircle = Shape.prototype.serialize.call(this);
            serializedCircle.radius = this._radius;
            return serializedCircle;
        };

        Circle.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.arc(this.serialize().x, this.serialize().y, this.serialize().radius, 0, 2 * Math.PI);
            this.canvas().element.fill();
        };

        Circle.prototype.toString = function () {
            return "Circle: " + JSON.stringify(this.serialize());
        };

        return Circle;
    }());

    var Rect = (function () {
        function Rect(x, y, color, width, height) {
            Shape.call(this, x, y, color);
            this._width = width;
            this._height = height;
        }

        Rect.extends(Shape);

        Rect.prototype.serialize = function () {
            var serializedRect = Shape.prototype.serialize.call(this);
            serializedRect.width = this._width;
            serializedRect.height = this._height;
            return serializedRect;
        };

        Rect.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.fillRect(this.serialize().x,
                this.serialize().y,
                this.serialize().width,
                this.serialize().height);
        };

        Rect.prototype.toString = function () {
            return "Rectangle: " + JSON.stringify(this.serialize());
        };

        return Rect;
    }());

    var Point = (function () {
        function Point(x, y, color) {
            Shape.call(this, x, y, color);
        }

        Point.extends(Shape);

        Point.prototype.serialize = function () {
            var serializedPoint = Shape.prototype.serialize.call(this);
            return serializedPoint;
        };

        Point.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.arc(this.serialize().x, this.serialize().y, 2, 0, 2 * Math.PI);
            this.canvas().element.fill();
        };

        Point.prototype.toString = function () {
            return "Point: " + JSON.stringify(this.serialize());
        };

        return Point;
    }());

    var Triangle = (function () {
        function Triangle(x, y, color, x2, y2, x3, y3) {
            Shape.call(this, x, y, color);
            this._x2 = x2;
            this._y2 = y2;
            this._x3 = x3;
            this._y3 = y3;
        }

        Triangle.extends(Shape);

        Triangle.prototype.serialize = function () {
            var serializedTriangle = Shape.prototype.serialize.call(this);
            serializedTriangle.x2 = this._x2;
            serializedTriangle.y2 = this._y2;
            serializedTriangle.x3 = this._x3;
            serializedTriangle.y3 = this._y3;
            return serializedTriangle;
        };

        Triangle.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.moveTo(this.serialize().x, this.serialize().y);
            this.canvas().element.lineTo(this.serialize().x2, this.serialize().y2);
            this.canvas().element.lineTo(this.serialize().x3, this.serialize().y3);
            this.canvas().element.fill();
        };

        Triangle.prototype.toString = function () {
            return "Triangle: " + JSON.stringify(this.serialize());
        };

        return Triangle;
    }());

    var Segment = (function () {
        function Segment(x, y, color, x2, y2) {
            Shape.call(this, x, y, color);
            this._x2 = x2;
            this._y2 = y2;
        }

        Segment.extends(Shape);

        Segment.prototype.serialize = function () {
            var serializedSegment = Shape.prototype.serialize.call(this);
            serializedSegment.x2 = this._x2;
            serializedSegment.y2 = this._y2;
            return serializedSegment;
        };

        Segment.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.moveTo(this.serialize().x, this.serialize().y);
            this.canvas().element.lineTo(this.serialize().x2, this.serialize().y2);
            this.canvas().element.strokeStyle = this.serialize().color;
            this.canvas().element.stroke();
            this.canvas().element.closePath();
        };

        Segment.prototype.toString = function () {
            return "Segment: " + JSON.stringify(this.serialize());
        };

        return Segment;
    }());

    return {
        Shape: Shape,
        Circle: Circle,
        Rect: Rect,
        Triangle: Triangle,
        Segment: Segment,
        Point: Point
    };

}());
