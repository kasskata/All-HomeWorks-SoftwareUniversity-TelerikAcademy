// Object.prototype.inherits = function inherits(parent) {
//     this.prototype = Object.create(parent.prototype);
//     this.prototype.constructor = this;
// }

String.prototype.isNullOrEmpty = function (content) {
    if (typeof (this.valueOf()) != 'string') {
        throw new Error(content + " must be String");
    }
    if (!this.valueOf()) {
        throw new Error(content + " cannot be undefined or empty");
    }
}

Boolean.prototype.isBoolean = function (status) {
    if (typeof (this.valueOf()) != 'boolean') {
        throw new Error(status + " must be Boolean value.");
    }
    return true;
}

var Item = (function () {

    function Item(content) {
        // .apply(this, arguments);
        this.setContent(content);
        this.setStatus(true);
    }

    // Get Status
    Item.prototype.getStatus = function () {
        return this._status;
    }

    // Set Status
    Item.prototype.setStatus = function (status) {
        status.isBoolean("status");
        this._status = status;
    }

    // Get Content
    Item.prototype.getContent = function () {
        return this._content;
    }

    // Set Content
    Item.prototype.setContent = function (content) {
        content.isNullOrEmpty("content");
        this._content = content;
    }

    Item.prototype.completeItem = function () {
        this.setStatus(false);
    }

    //function for AddToDom
    Item.prototype.AddToDom = function () {
        //Нямаме време да си чертаем картинки по страници... А и няма с нищо да ми помогне за изпита
    }

    Item.prototype.toString = function () {
        return "//// Content: " + this.getContent() +
            " Status:" + (this.getStatus() === true ? " Not complete" : " Complete");
    }

    return Item;
}());
//=====================================================


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
//=====================================================


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

var s = new Section("Dnes");
s.addItem(new Item("Miem zybki"));
s.addItem(new Item("Dushim smoka"));
s.getItems()[0].completeItem();
s.removeCompleted();

var tomorow = new Section("Utre be");
tomorow.addItem(new Item("Byrkam u pupa cel den"));
tomorow.addItem(new Item("Piem beer"));

var c = new Container();
c.addSection(s);
c.addSection(tomorow);
console.log(c.toString());

