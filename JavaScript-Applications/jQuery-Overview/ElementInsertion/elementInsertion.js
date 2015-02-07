(function () {
    $("#afterBtn").on('click', function () {
        $value = $("#value").val();
        $item = $("<li></li>");
        $item.text($value);
        $("#list").append($item);
        $value = $("#value").val("");
    });

    $("#beforeBtn").on('click', function () {
        $value = $("#value").val();
        $item = $("<li></li>");
        $item.text($value);
        $("#list").prepend($item);
        $value = $("#value").val("");
    });
})();