/// <reference path="underscore-min.js" />
/// <reference path="backbone-min.js" />
/// <reference path="jquery-1.5.1.js" />

var tf = tf || {};

//create a bb Book Model prototype (class)
tf.BookModel = Backbone.Model.extend({
    incrementLikes: function () {
        this.save({ 'Likes': this.get('Likes') + 1 });
    },
    url: '/'
});

//create the BookView prototype (class)    
tf.BookView = Backbone.View.extend({
    tagName: 'li',
    events: {
        'click .l': 'like'
    },
    initialize: function () {
        var self = this;
        //subscribe to the model change
        this.model.on('change', function () {
            self.render();
        });
    },
    like: function () {
        //increment the likes
        this.model.incrementLikes();
    },
    render: function () {
        this.$el.html(_.template($('#bookTemplate').html(), this.model.toJSON()));
        return this;
    }
});
