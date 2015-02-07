(function () {
    require.config({
        paths: {
            'container': 'container',
            'section': 'section',
            'item': 'item'
        }
    });
    require(['container'], function (Container) {
        var container = new Container('TODO List');
        container.add(document.body);
    })
})();
