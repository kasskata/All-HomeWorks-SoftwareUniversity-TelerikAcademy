(function () {

    var User = (function () {
        function User(rootUrl) {
            this.serviceUrlLogin = rootUrl + 'classes/Bookmark/';
        }

        User.prototype.getUser = function (acc, pass, success, error) {
            return ajaxRequester.get(this.serviceUrlLogin, acc, pass, success, error);
        }

        User.prototype.add = function (student, success, error) {
            return ajaxRequester.post(this.serviceUrlLogin, student, success, error);
        }

        User.prototype.delete = function (id, success, error) {
            return ajaxRequester.delete(this.serviceUrlLogin + id, success, error);
        }

        return User;
    }());

    var Bookmarks = (function () {
        function Bookmarks(rootUrl) {
            this.serviceUrlLogin = rootUrl + 'classes/Bookmark/';
        }

        Bookmarks.prototype.getAll = function (success, error) {
            return ajaxRequester.get(this.serviceUrlLogin, success, error);
        }

        Bookmarks.prototype.add = function (student, success, error) {
            return ajaxRequester.post(this.serviceUrlLogin, student, success, error);
        }

        Bookmarks.prototype.delete = function (id, success, error) {
            return ajaxRequester.delete(this.serviceUrlLogin + id, success, error);
        }

        return Bookmarks;
    }());

    return {
        user: User,
        bookmark: Bookmarks
    }
})();