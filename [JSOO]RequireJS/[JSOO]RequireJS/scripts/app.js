require.config({
    paths: {
        "item": 'item',
        "section": 'section',
        "container": 'container'
    }
});

require(['item', 'section', 'container'], function (Item, Section, Container) {

    var s = new Section("Dnes");
    s.addItem(new Item("Miem zybki"));
    s.addItem(new Item("Dushim smoka"));
    s.getItems()[0].completeItem();
    s.removeCompleted();

    var tomorow = new Section("Utre be");
    tomorow.addItem(new Item("Byrkam u pupa cel den"));
    tomorow.addItem(new Item("Piem beer"));

    var c = new Container();
    c.addSection(s);
    c.addSection(tomorow);
    console.log(c.toString());

});