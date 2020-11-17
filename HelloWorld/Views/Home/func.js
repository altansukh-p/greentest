var router = require('express');

router.get('/', function(req, res){
    res.render('index', {title: 'Express'});
});

router.get('/logEntries', function(req, res){
    var node = req.query.note || "Node0";

    var db = req.db;

    var collection = db.get(note);

    collection.find({}).then(function(docs){
        res.render('logEntires', {"noteName":note, "log": docs});
    });
});

module.exports = router;