$(document).ready(function () {
    var appID = "ibukcs4HwxxYo64HGsjc3eBDRYEq2Z1w2B7ABjKW";
    var masterKey = "7m7YzgIoAQ64fktlNhuTgUC5zEFHGekdVPnDwXiO";
    var contentType = "application/json";
//    Parse.initialize(appID, masterKey);

    $.ajax({
        method: "GET",
        url: "https://api.parse.com/1/classes/Book",
        content: contentType,
        headers: {
            "X-Parse-Application-Id": appID,
            "X-Parse-REST-API-Key": masterKey
        },
        success: onSuccess,
        error: onError
    });

    function onSuccess(data) {
        var dataJSON = data["results"];
        for (var i = 0; i < dataJSON.length; i++) {
            var $ul = $('<ul/>')
                .text('Book' + (i + 1) + '')
                .addClass("Author" + (i + 1) + "")
                .append($('<a href="#" id="' + dataJSON[i]['objectId'] + '" class="edit-book' + i + '">[Edit]</a>')
                    .click(editBook()))
                .append($('<a href="#" id="' + dataJSON[i]['objectId'] + '" class="delete-book' + i + '">[Delete]</a>')
                    .click(deleteBook()))
                .appendTo($('body'));
            $('<li/>').html(dataJSON[i]['Author']).appendTo($ul);
            $('<li/>').html(dataJSON[i]['Title']).appendTo($ul);
            $('<li/>').html(dataJSON[i]['ISBN']).appendTo($ul);
        }
    }

    function onError(data) {
        throw new Error("Can't locate JSON Objects")
    }

    function editBook() {
        return (function () {
            var $this = $(this);
            $('<input type="text" id="new-ISBN" placeholder="New ISBN*"/>').insertAfter($(this));
            $('<input type="text" id="new-author" placeholder="New Author*"/>').insertAfter($(this));
            $('<input type="text" id="new-title" placeholder="New Title*"/>').insertAfter($(this));

            $('<input type="button" id="new-submit' + $this.attr('id') + '" value="Edit Book on server"/>')
                .click(function () {
                    $.ajax({
                        method: "PUT",
                        url: "https://api.parse.com/1/classes/Book/" + $this.attr('id') + "",
                        content: contentType,
                        headers: {
                            "X-Parse-Application-Id": appID,
                            "X-Parse-REST-API-Key": masterKey
                        },
                        data: JSON.stringify({"Title": validateString($('#new-title').val()), "ISBN": validateString($('#new-ISBN').val()), "Author": validateString($('#new-author').val())}),
                        success: onSuccess,
                        error: onError
                    });

                    function onSuccess(data) {
                        alert('Success operation.');
                        location.reload();
                    }

                    function onError(data) {
                        var data = data["results"];
                    }
                })
                .insertAfter($(this));
        });
    }

    $('#submit').click(addNewBook());

    function deleteBook() {
        return (function () {
            var $this = $(this);
            $.ajax({
                method: "DELETE",
                url: "https://api.parse.com/1/classes/Book/" + $this.attr('id') + "",
                content: contentType,
                headers: {
                    "X-Parse-Application-Id": appID,
                    "X-Parse-REST-API-Key": masterKey
                },
                success: onSuccess,
                error: onError
            });

            function onSuccess(data) {
                alert('Success operation.');
                location.reload();
            }

            function onError(data) {
                var data = data["results"];
            }
        });
    }

    function addNewBook() {
        return (function () {
            var title = validateString($('#title').val());
            var author = validateString($('#author').val());
            var isbn = validateString($('#ISBN').val());

            $.ajax({
                method: "POST",
                url: "https://api.parse.com/1/classes/Book",
                content: contentType,
                headers: {
                    "X-Parse-Application-Id": appID,
                    "X-Parse-REST-API-Key": masterKey
                },
                data: JSON.stringify({"Title": title, "ISBN": isbn, "Author": author}),
                success: onSuccess,
                error: onError
            });

            function onSuccess(data) {
                alert('Success operation');
                location.reload();
            }

            function onError() {
            }
        });
    }
    function validateString(string){
        if(!string){
            throw new Error('Ca\'t be empty string.');
        }
        return string;
    }
});