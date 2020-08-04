jQuery(document).ready(function () {

    $('input').on('keydown', function (e) {
        if (e.keyCode == 38) { // Up
            var previousEle = $(this).prev();
            if (previousEle.length == 0) {
                previousEle = $(this).nextAll().last();
            }
            var selVal = $('.selectpicker option').filter(function () {
                return $(this).text() == previousEle.text();
            }).val();
            $('.selectpicker').selectpicker('val', selVal);

            return;
        }
        if (e.keyCode == 40) { // Down
            var nextEle = $(this).next();
            if (nextEle.length == 0) {
                nextEle = $(this).prevAll().last();
            }
            var selVal = $('.selectpicker option').filter(function () {
                return $(this).text() == nextEle.text();
            }).val();
            $('.selectpicker').selectpicker('val', selVal);

            return;
        }
    });

    var pickerkeydown = function () {
        console.log('e');
    };
});