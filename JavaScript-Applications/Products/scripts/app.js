'use strict';

(function () {

    showGuestView();
    registerEventHandlers();

    function showGuestView() {
        $("#main > *").hide();
        $("#login-menu").hide();
        $("#welcome-guest").show();
    }

    function loadUserHomeScreen() {
        $("#main > *").hide();
        $("#welcome-user-view").show();
        $("#main-menu").hide();
        $("#login-menu").show();
        var currentUser = userSession.getCurrentUser();
        $("#welcome-user-view .main-header").text("Welcome, " + currentUser.username + " !");

    }

    function redirectToLogin() {

        $("#main > *").hide();
        $("#login-menu").hide();
        $("#main-menu").show();
        $("#login-view").show();
    }

    function redirectToRegister() {
        $("#main > *").hide();
        $("#login-menu").hide();
        $("#main-menu").show();
        $("#register-view").show();
    }


    function redirectToAddProduct() {
        $("#main > *").hide();
        $("#login-menu").show();
        $("#main-menu").hide();
        $("#add-view").show();
    }

    function redirectToProducts() {
        $("#main > *").hide();
        $("#login-menu").show();
        $("#main-menu").hide();
        $("#product-list-view").show();
        ajaxRequester.getProducts(loadProducts, errorAjax);
    }

    function loadProducts(data) {
        for (var p in data.results) {
            var product = data.results[p];
            var id = product.objectId;
            var productLi = $("<li>");
            productLi.attr('class', 'product');

            productLi.html('<div class="product-info">' +
                '<p class="item-name">' + product.name + '</p>' +
                '<p class="category"><span class="pre">Category:</span>' + product.category +
                '</p><p class="price"><span class="pre">Price:</span>' + product.price +
                '</p></div>');


            var footer = $("<footer>").attr('class', "product-footer");
            var editEl = $('<a href="#">');
            var editBtn = $('<button>').attr('class', "edit-button").text("Edit");
            editBtn.attr('data', id);
            var deleteEl = $('<a href="#">');
            var deleteBtn = $('<button>').attr('class', "delete-button").attr('id', id).text("Delete");


            editBtn.appendTo(editEl);
            editEl.appendTo(footer);
            deleteBtn.appendTo(deleteEl);
            deleteEl.appendTo(footer);
            footer.appendTo(productLi);

            $(".products > ul").append(productLi);
        }
    }

    function login() {
        var username = $("#login-view #username").val();
        var password = $("#login-view #password").val();
        ajaxRequester.login(username, password, successLogin, errorAjax);

        loadUserHomeScreen();
    }

    function logout() {
        userSession.logout();
        redirectToLogin();
        logoutSuccessfully();
    }

    function register() {
        var username = $("#register-view #username").val();
        var password = $("#register-view #password").val();
        var passwordConfirm = $("#register-view #confirm-password").val();
        if (password === passwordConfirm) {
            ajaxRequester.register(username, password, successRegister, errorAjax);
        } else {
            errorPasswordConfirm();
        }

    }

    function addProduct() {
        var name = $("#name").val();
        var category = $("#category").val();
        var price = parseFloat($("#price").val());
        var currentUser = userSession.getCurrentUser();
        var sessionToken = currentUser.sessionToken;

        ajaxRequester.addProduct(name, category, price, currentUser.objectId, sessionToken, addedSuccessfully, errorAjax);
    }

    function cancelAdd() {
        redirectToProducts();
    }

    function registerEventHandlers() {
        $("#login-btn").click(redirectToLogin);
        $("#login-button").click(login);
        $("#register-button").click(register);

        $("#nav-btn-register").click(redirectToRegister);
        $("#nav-btn-home").click(showGuestView);
        $("#nav-btn-login").click(redirectToLogin);

        $("#redirect-to-login").click(redirectToLogin);
        $("#redirect-to-register").click(redirectToRegister);

        $("#nav-button-home").click(loadUserHomeScreen);
        $("#nav-btn-add").click(redirectToAddProduct);
        $("#nav-btn-logout").click(logout);
        $("#nav-btn-products").click(redirectToProducts);

        $("#add-product-button").click(addProduct);
        $("#cancel-add").click(cancelAdd);


        $('#products-wrapper>ul').on('click', '.delete-button', function (ev) {

            var currentUser = userSession.getCurrentUser();
            var sessionToken = currentUser.sessionToken;
            var id = $(this).attr('id');
            noty(
                {
                    text: "Delete this product?",
                    type: 'confirm',
                    layout: 'topCenter',
                    buttons: [
                        {
                            text: "Yes",
                            onClick: function ($noty) {
                                ajaxRequester.deleteProduct(sessionToken, id, deletedSuccessfully, errorAjax);
                                $noty.close();
                            }
                        },
                        {
                            text: "Cancel",
                            onClick: function ($noty) {
                                $noty.close();
                            }
                        }
                    ]}
            );
        });

        $('#products-wrapper>ul').on('click', '.edit-button', function (ev) {
            var id = $(this).attr('data');
            $("#main > *").hide();
            $('#edit-view').show();
            $('#edit-product-button').on('click', function () {
                var currentUser = userSession.getCurrentUser();
                var sessionToken = currentUser.sessionToken;
                var name = $("#edit-view #item-name").val();
                var category = $("#edit-view #category").val();
                var price = parseFloat($("#edit-view #price").val());
                var updatedProduct = {name: name, category: category, price: price};
                ajaxRequester.editProduct(sessionToken, id, updatedProduct, editedSuccessfully, errorAjax);
            });
        })
    }

    function errorAjax() {
        noty({
                text: "Ajax error",
                type: 'error',
                layout: 'bottomCenter',
                timeout: 5000}
        );
    }

    function errorPasswordConfirm() {
        noty({
                text: " Passwords did not match",
                type: 'error',
                layout: 'bottomCenter',
                timeout: 5000}
        );
    }

    function successLogin(data) {
        userSession.login(data);

        noty({
                text: "Login successful",
                type: 'success',
                layout: 'bottomCenter',
                timeout: 2000}
        );
    }

    function deletedSuccessfully(data) {
        userSession.login(data);

        noty({
                text: "Deleted successfully",
                type: 'success',
                layout: 'bottomCenter',
                timeout: 2000}
        );
    }

    function addedSuccessfully() {
        redirectToProducts();
        noty({
                text: "Added successfully",
                type: 'success',
                layout: 'bottomCenter',
                timeout: 2000}
        );
    }

    function logoutSuccessfully() {
        noty({
                text: "Logout successfully",
                type: 'success',
                layout: 'bottomCenter',
                timeout: 2000}
        );
    }

    function editedSuccessfully() {
        redirectToAddProduct();
        noty({
                text: "Edited successfully",
                type: 'success',
                layout: 'bottomCenter',
                timeout: 2000}
        );
    }

    function successRegister() {
        noty({
                text: "Register successful",
                type: 'success',
                layout: 'bottomCenter',
                timeout: 2000}
        );
    }
}());
