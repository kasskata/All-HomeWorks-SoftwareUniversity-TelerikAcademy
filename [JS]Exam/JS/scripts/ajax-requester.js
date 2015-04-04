var ajaxRequester = (function () {
    var baseUrl = "https://api.parse.com/1/";
    var headers = {
        "X-Parse-Application-Id": "ibukcs4HwxxYo64HGsjc3eBDRYEq2Z1w2B7ABjKW",
        "X-Parse-REST-API-Key": "7m7YzgIoAQ64fktlNhuTgUC5zEFHGekdVPnDwXiO"
    }
    var makeRequest = function makeRequest(method, url, data, headers, success, error) {
        return $.ajax({
            method: method,
            url: url,
            headers: headers,
            contentType: 'application/json',
            data: data,
            success: success,
            error: error
        })
    }

    function includeToken(sessionToken) {
        var headerToken = JSON.parse(JSON.stringify(headers));
        headerToken["X-Parse-Session-Token"] = sessionToken;
        return headerToken;
    }

    function login(acc, pass, success, error) {
        var data = {username: acc, password: pass};
        return makeRequest('GET', baseUrl + "login", data, headers, success, error);
    }

    function register(acc, pass, fullName, success, error) {
        var data = JSON.stringify({username: acc, password: pass, fullName: fullName});
        return makeRequest('POST', baseUrl + "users", data, headers, success, error);

    }

    function makeGetRequest(sessionToken, data, success, error) {
        return makeRequest('GET', baseUrl + 'classes/Phonebook', data, includeToken(sessionToken), success, error);
    }

    function makePostRequest(sessionToken, data, success, error) {
        return makeRequest('POST', baseUrl + 'classes/Phonebook', data, includeToken(sessionToken), success, error);
    }

    function makePutRequest(sessionToken, id, data, success, error) {
        return makeRequest('PUT', baseUrl + 'classes/Phonebook/' + id, data, includeToken(sessionToken), success, error);
    }

    function makeDeleteRequest(id, sessionToken, success, error) {
        return makeRequest('DELETE', baseUrl + 'classes/Phonebook/' + id, null, includeToken(sessionToken), success, error);
    }

    function editProfile(sessionToken, id, data, success, error) {
        return makeRequest('PUT', baseUrl + 'users/' + id, data, includeToken(sessionToken), success, error);
    }

    return {
        putUser:editProfile,
        login: login,
        register: register,
        get: makeGetRequest,
        post: makePostRequest,
        put: makePutRequest,
        delete: makeDeleteRequest
    }
}());