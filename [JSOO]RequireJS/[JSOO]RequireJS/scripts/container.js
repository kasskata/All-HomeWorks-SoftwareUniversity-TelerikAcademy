define(['item','section'],function(){
    var Container = (function () {

        function Container() {
            this.setSections();
        }

        // Get Sections
        Container.prototype.getSections = function () {
            return this._sections;
        }

        // Set Sections
        Container.prototype.setSections = function () {
            this._sections = [];
        }

        Container.prototype.addSection = function (section) {
            this.getSections().push(section);
        }

        //function for removeISections
        Container.prototype.removeISections = function (index) {
            index = parseInt(index);
            this.getSections().splice(index, 1);
        }

        //function for AddToDom
        Container.prototype.AddToDom = function () {
            //Нямаме време да си чертаем картинки по страници... А и няма с нищо да ми помогне за изпита!
        }

        Container.prototype.toString = function () {
            var result = this.constructor.name + "\n";
            if (this.getSections().length != 0) {
                for (var i = 0; i < this.getSections().length; i++) {
                    result += this.getSections()[i].toString() + "\n";
                }
            } else {
                result += " No sections yet."
            }
            return result;
        }
        return Container;
    }());
});