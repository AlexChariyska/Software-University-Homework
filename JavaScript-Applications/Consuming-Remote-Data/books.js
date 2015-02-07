$(function () {
    var booksArr = [];

    loadBooks();

    function loadBooks() {
        ajaxRequester.get("https://api.parse.com/1/classes/Book", booksLoaded);
    }

    function booksLoaded(data) {
        var header = $('<h1>').text("Books List:");
        header.appendTo($("#books"));

        for (var b in data.results) {
            var book = data.results[b];

            var btnDelete = $('<button>').text("Delete")
                .attr('id', book.title)
                .on("click", function () {
                    deleteBook($(this).attr("id"));
                });

            var bookItem = $('<li>');
            var bookLink = $("<a href='#'>").text("Title: " + book.title
                + " Author: " + book.author
                + " ISBN: " + book.isbn + " ");
            $(bookLink).data('book', book);
            bookLink.click(clickedLink);


            bookLink.appendTo($(bookItem));
            bookItem.appendTo($("#books"));
            btnDelete.appendTo($(bookItem));
        }

        booksArr = data;
        submitBtn();
    }

    function clickedLink() {
        var book = $(this).data('book');

        $("#editContainer").append('<h1>Edit book ' + book.title + '</h1>' +
            '<span>Title: </span><input id="editedTitle" type="text" placeholder="Title"> ' +
            '<br/><span>Author: </span><input id="editedAuthor" type="text" placeholder="Author"> ' +
            '<br/><span>Isbn: </span><input id="editedIsnb" type="text" placeholder="ISBN"> <br/>');

        var btnSubmitChanges = $('<button>').text("Edit :)")
            .attr('class', book.title)
            .on("click", function () {
                sendEditChanges($(this).attr("class"));
            });

        btnSubmitChanges.appendTo($('#editContainer'));
    }

    function sendEditChanges(title) {
        var bookId = findByTitleId(title);

        editTitle = $('#editedTitle').val() == "" ? title : $('#editedTitle').val();
        editAuthor = $('#editedAuthor').val() == "" ? findByTitleAuthor(title) : $('#editedAuthor').val();
        editIsbn = $('#editedIsnb').val() == "" ? findByTitleIsbn(title) : $('#editedIsnb').val();

        ajaxRequester.put('https://api.parse.com/1/classes/Book/' + bookId, {
            'title': encodeURI(editTitle),
            'author': encodeURI(editAuthor),
            'isbn': encodeURI(editIsbn)
        }, editedSuccesfully);
    }

    function submitBtn() {

        var btn = $('<button>').text("Submit").on("click", function () {
            if (!($("#title").val() == "")) {
                createBook(($("#title").val()), ($("#author").val()), ($("#isnb").val()));
            }
        });
        $("#books").append('<input id="title" type="text" placeholder="Title"><br/>' +
            '<input id="author" type="text" placeholder="Author"><br/>' +
            '<input id="isnb" type="text" placeholder="ISBN"><br/>');

        btn.appendTo($("#books"));
    }

    function createBook(bookName, author, isbn) {
        ajaxRequester.post ('https://api.parse.com/1/classes/Book/', {
            'title': bookName,
            'author': author,
            'isbn': isbn
        }, addedSuccesfully);

    }

    function deleteBook(book) {
        var bookId = findByTitleId(book);
        ajaxRequester.delete('https://api.parse.com/1/classes/Book/' + bookId, deletedSuccesfully);
    }

    function findByTitleId(searchedVariable) {
        var itemID;
        for (var x in booksArr.results) {
            var item = booksArr.results[x];
            if (item.title === searchedVariable) {
                itemID = item.objectId;
                return itemID;
            }
        }
    }

    function findByTitleAuthor(searchedVariable) {
        for (var x in booksArr.results) {
            var item = booksArr.results[x];
            if (item.title === searchedVariable) {
                return item.author;
            }
        }
    }

    function findByTitleIsbn(searchedVariable) {
        for (var x in booksArr.results) {
            var item = booksArr.results[x];
            if (item.title === searchedVariable) {
                return item.isbn;
            }
        }
    }


    function addedSuccesfully() {
        noty({
                text: 'Successfully added',
                layout: 'topCenter',
                timeout: 2000}
        );

        setInterval(function () {
            location.reload();
        }, 3000);
    }

    function editedSuccesfully() {
        noty({
                text: 'Edited added',
                layout: 'topCenter',
                timeout: 2000}
        );

        setInterval(function () {
            location.reload();
        }, 3000);
    }

    function deletedSuccesfully() {
        noty({
                text: 'Successfully deleted',
                layout: 'topCenter',
                timeout: 2000}
        );

        setInterval(function () {
            location.reload();
        }, 3000);
    }


});