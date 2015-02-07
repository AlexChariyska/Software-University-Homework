'use strict';

var ajaxRequester = (function () {
    var baseUrl = "https://api.parse.com/1/";

    var headers =
    {
        "X-Parse-Application-Id": "xYgBzPrCvbAkJQFM1vELii8Wqe09S04L2aOZ5IqY",
        "X-Parse-REST-API-Key": "cnPKoebccL3KMhxnThwTLJhT8LflYDYdIbJhCEvZ"
    };

    function login(username, password, success, error) {
        jQuery.ajax({
            method: "GET",
            headers: headers,
            url: baseUrl + "login",
            data: {username: username, password: password},
            success: success,
            error: error
        });
    }

    function register(username, password, success, error) {
        jQuery.ajax({
            method: "POST",
            headers: headers,
            url: baseUrl + "users",
            data: JSON.stringify({username: username, password: password}),
            success: success,
            error: error
        });
    }

    function getHeadersWithSessionToken(sessionToken) {
        var headersWithToken = JSON.parse(JSON.stringify(headers));
        headersWithToken['X-Parse-Session-Token'] = sessionToken;
        return headersWithToken;
    }

    function getProducts(success, error) {
        jQuery.ajax({
            method: "GET",
            headers: headers,
            url: baseUrl + "classes/Product",
            success: success,
            error: error
        });
    }

    function addProduct(name, category, price, userId, sessionToken, success, error) {
        var product = {name: name, category: category, price: price, ACL: {}};
        product.ACL[userId] = {"write": true, "read": true};
        jQuery.ajax({
            method: "POST",
            headers: getHeadersWithSessionToken(sessionToken),
            url: baseUrl + "classes/Product",
            data: JSON.stringify(product),
            success: success,
            error: error
        });
    }

    function deleteProduct(sessionToken, productId, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "DELETE",
            headers: headersWithToken,
            url: baseUrl + "classes/Product/" + productId,
            success: success,
            error: error
        });
    }

    function editProduct(sessionToken, productId, data, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "PUT",
            headers: headersWithToken,
            url: baseUrl + "classes/Product/" + productId,
            data: JSON.stringify(data),
            success: success,
            error: error
        });
    }

    return {
        login: login,
        register: register,
        getProducts: getProducts,
        addProduct: addProduct,
        deleteProduct: deleteProduct,
        editProduct: editProduct
    };

})();