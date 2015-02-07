(function () {
    $("#btnPrint").on('click', function () {
        $class = "." + $("#class").val().toLowerCase();
        $color = $("#color").val();
        $($class).css("background-color", $color);
    });
})();
