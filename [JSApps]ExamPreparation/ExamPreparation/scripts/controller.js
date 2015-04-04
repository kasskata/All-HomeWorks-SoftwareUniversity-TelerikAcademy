(function () {
    $(function () {
        if (!sessionStorage['currentUser']) {
            showThatSection('.home');
        }
        else {
            authSuccess(sessionStorage['currentUser']);
        }
        attachEvents();
//След като можете да видите домашното ми преди изпита искам да Ви демонстрирам
// моето решение на изпитната задача от подготовката.
// Надявам се да съм помогнал за Вашия изпит.
// Не съм писал домашното с темплейти, защото за мен е по-важно
// да съм готов за изпита, отколкото да разучавам нови техники, когато
// му дойде времето ще ги разуча. Сега няма време(Unity проект, JS App проект, семейни проблеми)
// Поздрави!
        function attachEvents() {
            $('#logoutBtn').on("click", onLogoutEvent);
            $('.loginForm').on("click", onLoginEvent);
            $('.registerForm').on("click", onRegisterEvent);
            $('#loginWithValues').on("click", onLoginSubmit);
            $("#registerWithValues").on("click", onRegisterSubmit);
            $("#submitNewBookmark").on("click", onNewBookmarkSubmit);
        }

        function onLoginSubmit() {
            var acc = $('#logAccValue').val();
            var pass = $('#logPassValue').val();

            ajaxRequester.login(acc, pass, authSuccess, onLoginSubmitError);
        }

        function onLoginSubmitError(error) {
            var error = error.responseJSON.error;
            showNotification('Login failed: ' + error, 'error');
        }

        function authSuccess(data) {
            $('.bookmarks ul').empty();
            $('#logoutBtn').empty();

            var user;
            showNotification("Login success.", 'success');
            if (!sessionStorage['currentUser']) {
                sessionStorage['currentUser'] = JSON.stringify(data);
                var user = data;
            }
            else {
                var user = JSON.parse(sessionStorage['currentUser']);
            }
            ajaxRequester.get(user.sessionToken, onLoadSuccess, onLoadFailed);

            $('body > header > ul > li:nth-child(2) > h2 > span').text('-' + user.username + '');
            $('#logoutBtn').append($('<a href="#">Logout</a>'));
            $('#logPassValue').val('');
            $('#RegPassValue').val('');
            $('#RegAccValue').val('');


        }

        function onLoadSuccess(dataRoot) {
            loadUserBookmarks(dataRoot);
        }

        function onLoadFailed(error) {
            var error = error.responseJSON.error;
            showNotification('Load failed.' + error, 'error');
        }

        function loadUserBookmarks(dataRoot) {
            showNotification('Load success', 'success');
            showThatSection(".bookmarks");
            var data = dataRoot.results;
            var $bookmarkRoot = $('.bookmarks ul');
            for (var i = 0; i < data.length; i++) {
                var bookmark = data[i];
                var $bookmark = $('<li id="' + bookmark.objectId + '">Title: ' + bookmark.title +
                    '<br/>URL: <a href="' + bookmark.url + '">' + bookmark.url + '</li>');
                var $deleteButton = $('<a href="#">Delete</a>').on('click', onDeleteButton);
                $bookmark.append($('<br/>')).append($deleteButton);
                $bookmarkRoot.append($bookmark);
            }
        }

        function onDeleteButton() {
            noty({
                text: 'Do you want to delete this bookmark?',
                buttons: [
                    {addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {

                        ajaxRequester.delete(id, sessionToken, onDeleteSuccess, onDeleteFailed);

                        $noty.close();
                        noty({text: 'You clicked "Ok" button', type: 'success', timeout: 1000});
                    }
                    },
                    {addClass: 'btn btn-danger', text: 'Cancel', onClick: function ($noty) {
                        $noty.close();
                        noty({text: 'You clicked "Cancel" button', type: 'error', timeout: 1000});
                    }
                    }
                ]
            });
            var id = $(this).parent().attr('id');
            var sessionToken = JSON.parse(sessionStorage['currentUser'])['sessionToken'];
        }

        function onDeleteSuccess() {
            showNotification('Delete successful.', 'success');

            authSuccess(sessionStorage['currentUser']);
        }

        function onDeleteFailed(error) {
            showNotification('Delete failed.' + error.responseJSON.error, 'error');
        }

        function onRegisterSubmit() {
            var acc = $('#RegAccValue').val();
            var pass = $('#RegPassValue').val();
            ajaxRequester.register(acc, pass, authSuccess, onRegisterFailed);
        }

        function onRegisterFailed(error) {
            showNotification('Registration failed.' + error.responseJSON.error, 'error');
        }

        function onLogoutEvent() {
            sessionStorage.clear();
            $('body > header > ul > li:nth-child(2) > h2 > span').empty();
            showThatSection('.login');
        }

        function onNewBookmarkSubmit() {
            var title = $('#newTitle').val();
            var url = $('#newUrl').val();
            var sessionToken = JSON.parse(sessionStorage['currentUser'])['sessionToken'];
            var id = JSON.parse(sessionStorage['currentUser']).objectId;
            var bookmarkNew = {title: title, url: url, ACL: {}};
            bookmarkNew.ACL[id] = {read: true, write: true};
            bookmarkNew = JSON.stringify(bookmarkNew);
            ajaxRequester.post(sessionToken, bookmarkNew, OnAddSuccess, OnAddFail);
        }

        function OnAddSuccess(data) {
            showNotification('Add success.','success');
            authSuccess(sessionStorage['currentUser']);
        }

        function OnAddFail(error) {
            var error = error.responseJSON.error;
            showNotification('Add failed.' + error, 'error');
        }

        function onRegisterEvent() {
            showThatSection(".register");
        }

        function onLoginEvent() {
            showThatSection(".login");
        }

        function showNotification(msg, type) {
            noty({
                    text: msg,
                    type: type,
                    layout: 'topRight',
                    timeout: 1000
                }
            );
        }

        function showThatSection(section) {
            $('#wrapper > *').hide();
            $('#wrapper ' + section + '').show();
        }
    });
}());