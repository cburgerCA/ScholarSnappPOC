$button = $('#SSButton');
$text = $('#SSStateAppend');
$email = $('#SSEmail');
$button.mouseup(function () {
    var url = $button.data('ssurl');
    if ($email.val() != null && $email.val() != '') {
        url += '&email=' + encodeURIComponent($email.val());
    }
    url += '&state=';
    //Use state as a unique parameter.
    var state = Sha1.hash((new Date()).getUTCMilliseconds()).toString();
    //Add extra items into the state to be loaded by our redirect page
    if ($text.val() != null && $text.val() != '') {
        state += '|' + $text.val();
    }
    url += encodeURIComponent(state);
    window.location.href = url;
});