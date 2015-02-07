(function ($) {
    $.fn.createMessage = function (selector) {
        var $this = $(this);

        $('<button>Success</button>')
            .attr('id', 'success')
            .appendTo(selector)
            .click(function () {
                box('Success');
            });

        $('<button>Error</button>')
            .attr('id', 'success')
            .appendTo(selector)
            .click(function () {
                box('Error');
            });


        function box(message) {
            var $box = $('<div>' + message + '</div>')
                .css('opacity', '0')
                .animate({
                    opacity: 1.0 // fade in
                }, 1000);

            $('#wrapper').append($box);


            // with this the message won't stay empty and fill up space
            setTimeout(
                function () {
                    $box.remove();
                },
                3000
            );
        }

        return $this;
    }
})(jQuery);

$(document).ready(function () {
    $.fn.createMessage('#wrapper');
});
