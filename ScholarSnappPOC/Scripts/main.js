$button = $('#SSButton');
$text = $('#SSStateAppend');
$email = $('#SSEmail');
$button.mouseup(function () {
    var url = $button.data('ssurl');
    if ($email.val() != null && $email.val() != '') {
        url += '&email=' + encodeURIComponent($email.val());
    }
    url += '&state=';
    var state = Sha1.hash(Math.random());
    if ($text.val() != null && $text.val() != '') {
        state += '&extra=' + encodeURIComponent($text.val());
    }
    url += state;
    window.location.href = url;
});