'use strict';

function slider() {

    function animate_slider() {
        $('#slider #' + shown).animate({
            opacity: 0 // fade out
        }, 1000);
        $('#slider #' + next_slide).animate({
            opacity: 1.0 // fade in
        }, 2000);

        shown = next_slide;
    }

    function choose_next() {
        next_slide = (shown == sliders_length) ? 1 : shown + 1;
        animate_slider();
    }

    $('#slider #1').css({"opacity": 1});


    var shown = 1;
    var next_slide;

    var sliders_length = $('.slide').length; // total slides
    var iv = setInterval(choose_next, 3000);


   $('.slider_nav').hover(function () {
        clearInterval(iv); // stop animation
    }, function () {
        iv = setInterval(choose_next, 3000); // resume animation
    });

    $("#prev").on('click', function () {
        next_slide = (shown == 1) ? sliders_length : shown - 1;
        animate_slider();
    });

    $('#next').on('click', function () {
        next_slide = (shown == sliders_length) ? 1 : shown + 1;
        animate_slider();
    });
}
window.onload = slider;
