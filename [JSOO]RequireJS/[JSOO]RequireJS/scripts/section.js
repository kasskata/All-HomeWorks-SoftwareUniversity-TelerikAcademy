define(["item"],function(){
    var Section = (function () {

        function Section(title) {
            this.setTitle(title);
            this.setItems();
        }

        // Get Items
        Section.prototype.getItems = function () {
            return this._items;
        }

        // Set Items
        Section.prototype.setItems = function () {
            this._items = [];
        }

        // Get Title
        Section.prototype.getTitle = function () {
            return this._title;
        }

        // Set Title
        Section.prototype.setTitle = function (title) {
            this._title = title;
        }

        Section.prototype.addItem = function (item) {
            this.getItems().push(item);
        }

        Section.prototype.removeCompleted = function () {
            for (var i = 0; i < this.getItems().length; i++) {
                if (this.getItems()[i]._status == false) {
                    this.getItems().splice(i, 1);
                }
            }
        }

        //function for AddToDom
        Section.prototype.AddToDom = function () {
            //Нямаме време да си чертаем картинки по страници... А и няма с нищо да ми помогне за изпита
        }


        Section.prototype.toString = function () {
            var result = this.constructor.name + "\n";
            result += "//" + this.getTitle().toString() + "\n";
            if (this.getItems().length != 0) {
                for (var i = 0; i < this.getItems().length; i++) {
                    result += this.getItems()[i].toString() + "\n";
                }
            } else {
                result += " No items yet."
            }
            return result;
        }

        return Section;
    }());
});

