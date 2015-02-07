var ajaxRequester = (function () {
    var PARSE_APP_ID = "jFrSxMhGfshFw2rLPxXTwMeQuof8KBN1kGBn7wsz";
    var PARSE_REST_API_KEY = "70bg3A5KHPfqTqcJVuIUTxprsIps1HYLskh2ti3c";

    var makeRequest = function makeRequest(method, url, data, success) {
        return $.ajax({
            type: method,
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            url: url,
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: success,
            error: ajaxError
        })
    }

    function makeGetRequest(url, success) {
        return makeRequest('GET', url, null, success);
    }


    function makePostRequest(url, data, success) {
        return makeRequest('POST', url, data, success);
    }

    function makePutRequest(url, data, success) {
        return makeRequest('PUT', url, data, success);
    }

    function makeDeleteRequest(url, success) {
        return makeRequest('DELETE', url, {}, success);
    }

    function ajaxError() {
        noty({
                text: 'Cannot load AJAX data.',
                type: 'error',
                layout: 'topCenter',
                timeout: 5000}
        );
    }
    return {
        get: makeGetRequest,
        post: makePostRequest,
        put: makePutRequest,
        delete: makeDeleteRequest
    }
}());
