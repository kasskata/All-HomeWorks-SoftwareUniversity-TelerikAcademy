(function () {
    $(function () {
        if (!sessionStorage['currentUser']) {
            showThatSection('#wellcome-screen');
        }
        else {
            authSuccess(sessionStorage['currentUser']);
        }
        attachEvents();

        function attachEvents() {
            $('#menu > li:nth-child(4) > a').on('click', showEditProfile);
            $('#register-form > p.buttons > a.link').on('click', showLogin);
            $('#login-form > p.buttons > a.link').on('click', showRegister);
            $('#menu > li:nth-child(1) > a').on('click', showHome);
            $('#logoutBtn').on("click", onLogoutEvent);
            $('#wellcome-screen > a:nth-child(2)').on("click", onLoginEvent);
            $('#wellcome-screen > a:nth-child(3)').on("click", onRegisterEvent);
            $('#login-form > p.buttons > a.button').on("click", onLoginSubmit);
            $("#register-form > p.buttons > a.button").on("click", onRegisterSubmit);
            $(".submitNewPhone").on("click", showAddForm);
            $('#menu > li:nth-child(2) > a').on("click", onPhonebookEvent);
        }

        function showEditProfile() {
            showThatSection('#edit-profile-form');

            var user = JSON.parse(sessionStorage['currentUser']);

            $('#edit-profile-form > p.buttons > a:nth-child(1)').on('click',function(){
                var newUsername = $('#ChangeUsername').val();
                var newPass = $('#ChangePassword').val();
                var newFullName = $('#ChangeFullName').val();
                if (user['username'] == newUsername || newUsername.length <= 2) {
                    showNotification('Username are the same or is empty','error');
                    throw new Error();
                }
                if (user['fullName'] == newFullName || newFullName.length <= 2) {
                    showNotification('Fullname are the same or is empty','error');
                    throw new Error();
                }

                var data = JSON.stringify({username: newUsername, password: newPass, fullName: newFullName});
                var sessionToken = user.sessionToken;
                var userId = user.objectId;
                ajaxRequester.putUser(sessionToken, userId,data,onEditUserSuccess,onEditUserFailed);
            });
        }

        function onEditUserSuccess(){
            showNotification('Edit your account successfully','success');
            authSuccess(sessionStorage['currentUser']);
            $('#ChangePassword').val('');
        }

        function onEditUserFailed(error){
            showNotification('Edit is failed.' + error.responseJSON.error, 'error');
        }

        function showLogin() {
            showThatSection('#login-form');
        }

        function showHome() {
            if (!sessionStorage['currentUser']) {
                showThatSection('#wellcome-screen');
            }
            else {
                authSuccess(sessionStorage['currentUser']);
            }
        }

        function showRegister() {
            showThatSection('#register-form');
        }

        function showAddForm() {
            showThatSection('#add-phone-form');
            $('#add-phone-form > p.buttons > a:nth-child(1)').on('click', onNewPhoneSubmit);
        }

        function onPhonebookEvent() {
            showThatSection('#phones');
        }

        function onLoginSubmit() {
            var acc = $('#log-username').val();
            var pass = $('#log-password').val();

            ajaxRequester.login(acc, pass, authSuccess, onLoginSubmitError);
        }

        function onLoginSubmitError(error) {
            var error = error.responseJSON.error;
            showNotification('Login failed: ' + error, 'error');
        }

        function authSuccess(data) {
            $('#phones').empty();

            var user;
            if (!sessionStorage['currentUser']) {
                sessionStorage['currentUser'] = JSON.stringify(data);
                user = sessionStorage['currentUser'];
            }
            else {
                user = JSON.parse(sessionStorage['currentUser']);
            }
            ajaxRequester.get(user.sessionToken, null, onLoadSuccess, onLoadFailed);

            $('#log-password').val('');
            $('#RegPassValue').val('');
            $('#RegAccValue').val('');

        }

        function onLoadSuccess(dataRoot) {
            loadUserPhoneMarks(dataRoot);
        }

        function onLoadFailed(error) {
            var errorMsg = error.responseJSON.error;
            showNotification('Load failed.' + errorMsg, 'error');
        }

        function loadUserPhoneMarks(dataRoot) {
            showNotification('Load success', 'success');
            showThatSection("#home");
            $('#home').empty();
            var user = JSON.parse(sessionStorage['currentUser']);

            $('#home').append($('<h1>Welcome, ' + user['fullName'] + ' (' + user['username'] + ')</h1>')).append($('<p>Please use the navigation menu on the left.</p>'));
            var data = dataRoot.results;
            var $phoneRoot = $('#phones');
            $phoneRoot.append($('<tr><th>Name</th><th>Phone</th><th>Action</th></tr>'));
            for (var i = 0; i < data.length; i++) {
                var phoneMark = data[i];
                var $phone = $('<tr id="' + phoneMark.objectId + '"><td>' + phoneMark.name + '</td><td>' + phoneMark.phone + '</td></tr>');
                var $td = $('<td/>').attr('id', phoneMark.objectId);
                $('<a href="#" id="' + phoneMark.objectId + '">Edit</a>').on('click',function () {
                    var id = $(this).parent().attr('id');
                    showThatSection('#edit-phone-form');
                    $('#edit-phone-form').empty();

                    $('#edit-phone-form').append($('<p><label for="personName">Name:</label><input type="text" id="edit-personName" placeholder="New name"></p>'))
                        .append($('<p><label for="phoneNumber">Number:</label><input type="text" id="edit-phoneNumber" placeholder="New phone"></p>'))
                        .append($('<p class="' + id + '"><a href="#" class="button">Edit</a>').on('click', onEditPhone)
                            .append($('<a href="#" class="button">Cancel</a></p>').on('click', onCancel)))
                }).appendTo($td);
                $('<a href="#" id="' + phoneMark.objectId + '">Delete</a>').on('click', onDeleteButton).appendTo($td);
                $phone.append($td);
                $phoneRoot.append($phone);
            }
        }

        function onEditPhone() {
            var newName = $('#edit-personName').val();
            var newPhone = $('#edit-phoneNumber').val();
            var data = JSON.stringify({name: newName, phone: newPhone});

            var id = $(this).attr('class');
            var sessionToken = JSON.parse(sessionStorage['currentUser'])['sessionToken'];

            ajaxRequester.put(sessionToken, id, data, onEditSuccess, onEditFailed);
        }

        function onCancel() {
            showThatSection('#edit-phone-form');
        }

        function onEditSuccess() {
            showNotification('Edit success', 'success');
            authSuccess(sessionStorage['currentUser']);
        }

        function onEditFailed(error) {
            showNotification('Edit failed.' + error.responseJSON.error, 'error');

        }

        function onDeleteButton() {
            noty({
                text: 'Do you want to delete this contact?',
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
            var id = $(this).attr('id');
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
            var fullName = $('#RegFullName').val();
            ajaxRequester.register(acc, pass, fullName, authSuccess, onRegisterFailed);

        }

        function onRegisterFailed(error) {
            showNotification('Registration failed.' + error.responseJSON.error, 'error');
        }

        function onLogoutEvent() {
            sessionStorage.clear();
            $('#phones').empty();
            $('body > header > ul > li:nth-child(2) > h2 > span').empty();
            showThatSection('#wellcome-screen');
        }

        function onNewPhoneSubmit() {
            var newName = $('#add-personName').val();
            var newPhone = $('#add-phoneNumber').val();
            var sessionToken = JSON.parse(sessionStorage['currentUser'])['sessionToken'];
            var id = JSON.parse(sessionStorage['currentUser']).objectId;
            var phoneNew = {name: newName, phone: newPhone, ACL: {}};
            phoneNew.ACL[id] = {read: true, write: true};
            phoneNew = JSON.stringify(phoneNew);
            ajaxRequester.post(sessionToken, phoneNew, OnAddSuccess, OnAddFail);
            $('#add-personName').val('');
            $('#add-phoneNumber').val('');
        }

        function OnAddSuccess() {
            showNotification('Add phone success.', 'success');
            authSuccess(sessionStorage['currentUser']);

        }

        function OnAddFail(error) {
            var errorMsg = error.responseJSON.error;
            showNotification('Add failed.' + errorMsg, 'error');
        }

        function onRegisterEvent() {
            showThatSection("#register-form");
        }

        function onLoginEvent() {
            showThatSection("#login-form");
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