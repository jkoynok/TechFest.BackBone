
//spay-query

$(document).ready(function () {

    var Likes = 0;
    var Title = 'Great Expectations';

    $('#foo').click(function () {
            //stuff
            Likes = Likes+1;
            UpdateLikes();
    });    

});

function UpdateLikes() {
    $('#foo').html(Title + '(' + Likes.toString() + ')');

}

//problems
// - storing state in global scope -> no objects
// - functions in global scope
// - wiring up event handlers in document ready
// - building up html strings