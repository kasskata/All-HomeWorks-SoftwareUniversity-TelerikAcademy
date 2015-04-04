(function () {
    $(function () {
        if (!sessionStorage['currentUser']) {
            showThatSection('.home');
        }
        else {
            authSuccess(sessionStorage['currentUser']);
        }
        attachEvents();

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
                user = data;
            }
            else {
                user = JSON.parse(sessionStorage['currentUser']);
            }
//DATA MODIFIER ON LOAD ACC
            // 'where='+JSON.stringify({})
            // 'order='+
//            Key	       |Operation
//            $lt	    >  |Less Than
//            $lte	   >=  |Less Than Or Equal To
//            $gt	    <  |Greater Than
//            $gte	   <=  |Greater Than Or Equal To
//            $ne	   !=  |Not Equal To
//            $in          |Contained In
//            $nin	       |Not Contained in
//            $exists      |A value is set for the key
//            $select      |This matches a value for a key in the result of a different query
//            $dontSelect  |Requires that a key's value not match a value for a key in the result of a different query
//            $all	       |Contains all of the given values
            ajaxRequester.get(user.sessionToken, 'where=' + JSON.stringify({country: {$nin: ["Bulgaria"]}, gender: {$in: ["Male"]}}), onLoadSuccess, onLoadFailed);
            // Here I type the requests:
            // 'where='+JSON.stringify({age: {age:{$gte:18,$lte:24}})
            // 'order=firstName,lastName'
            // 'where='+JSON.stringify({country:"Bulgaria"})
            // can't take directly from parse.com, but can stop for loop
            // 'where='+JSON.stringify({country:{$nin:["Bulgaria"]},gender:{$in:["Male"]}})

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
            var errorMsg = error.responseJSON.error;
            showNotification('Load failed.' + errorMsg, 'error');
        }

        function loadUserBookmarks(dataRoot) {
            showNotification('Load success', 'success');
            showThatSection(".bookmarks");
            var data = dataRoot.results;
            var $bookmarkRoot = $('.bookmarks ul');
            for (var i = 0; i < data.length; i++) {
                var bookmark = data[i];
//HERE GET AND SPIT TO THE HTML
                var $bookmark = $('<li id="' + bookmark.objectId + '">Gender: <strong>' + bookmark.gender + '</strong>' +
                    '<br>' + 'First Name: <strong>' + bookmark.firstName + '</strong>' +
                    '<br>' + 'Last Name: <strong>' + bookmark.lastName + '</strong>' +
                    '<br>' + 'Age: <strong>' + bookmark.age + '</strong>' +
                    '<br>' + 'Country: <strong>' + bookmark.country + '</strong>' + '</li>');
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

        function OnAddSuccess() {
            showNotification('Add success.', 'success');
            authSuccess(sessionStorage['currentUser']);
        }

        function OnAddFail(error) {
            var errorMsg = error.responseJSON.error;
            showNotification('Add failed.' + errorMsg, 'error');
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