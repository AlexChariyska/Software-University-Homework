(function ($) {
    $.fn.treeView = function (selector) {
        function handler(event) {
            var target = $(event.target);
            if (target.is("li")) {
                target.children().toggle();
            }
        }

        $(selector).click(handler).find("ul").hide();

        return $this;
    }
})(jQuery);

$(document).ready(function () {
    $.fn.treeView('.main');
});