define(function(){
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
});


