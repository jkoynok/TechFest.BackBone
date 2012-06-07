//spay-query   
$(document).ready(function () {
    //fields in global scope
    var Likes = 0;
    var Title = 'Great Expectations';
    //manual event wireups in document ready
    $('#').click(function () {
        Likes = Likes + 1;
            //calls to funcs in global
            UpdateLikes();
        });             
});

function UpdateLikes() {
    //save to db - >
    $.ajax('/url', Likes, function () {
        $('#books').append('<li>' + Title + '(' + Likes.toString() + ')</li>');
    });
}

//problems
// - storing state in global scope -> no objects
// - no separation between model and view
// - wiring up event handlers in document ready
// - building up html strings
// - resists maintenance 