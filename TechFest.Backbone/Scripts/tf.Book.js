
var tf = tf || {};

//create a bb Book Model prototype (class)
tf.BookModel = Backbone.Model.extend({
    IncrementLikes: function () {
        this.set({ Likes: this.get('Likes') + 1 });
    }
});


//create the BookView prototype (class)    
tf.BookView = Backbone.View.extend({
    tagName: 'li',
    events: {
        'click': 'like'
    },
    like: function () {
        //increment the likes
        this.model.IncrementLikes();
        this.render();
    },
    render: function () {
        $(this.el).html(this.model.get('Title') + '(' + this.model.get('Likes') + ' likes)');
        return this;
    }
});
