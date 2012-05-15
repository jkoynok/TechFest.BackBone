

//spay-query
$(document).ready(function () {
    //initial fields in global scope
    var Likes = 0;
    var Title = 'Great Expectations';

    //manual event wireups in document ready
    $('#foo').click(function () {
            //stuff
            Likes = Likes+1;
            UpdateLikes();
        });    


});

//global scope functions
function UpdateLikes() {
    //save to db - >
    $('#foo').html(Title + '(' + Likes.toString() + ')');
}

//problems
// - storing state in global scope -> no objects
// - functions in global scope
// - wiring up event handlers in document ready
// - building up html strings