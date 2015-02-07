define(function () {
    'use strict';
    var Item;
    Item = (function () {
        function Item(content, itemContent) {
            if (content === "") {
                itemContent.placeholder = "Item title cannot be empty!";
                throw Error('The item content cannot be empty');
            }
            this._content = content;
        }
        
        Item.prototype.add = function (parent) {
            var item, lastItem, checkbox, _self, content;
            
            function isChecked() {
                var itemContent;
                itemContent = document.getElementById('item' + this._id);
                if (document.getElementById(this._id).checked) {
                    itemContent.style.backgroundColor = 'green';
                }
                else {
                    itemContent.style.backgroundColor = 'white';
                }
            }
            
            item = document.createElement('div');
            lastItem = parent.lastChild.previousSibling;
            if (lastItem != undefined) {
                if (lastItem.id != '') {
                    this._id = parent.id[parent.id.length - 1] +
                        (Number(lastItem.id[lastItem.id.length - 1]) + 1);
                    item.id = 'item' + this._id;
                }
                else {
                    this._id = parent.id[parent.id.length - 1] + 1;
                    item.id = 'item' + parent.id[parent.id.length - 1] + 1;
                }
                
                checkbox = document.createElement('input');
                checkbox.type = 'checkbox';
                checkbox.id = this._id;
                
                _self = this;
                checkbox.addEventListener("click", function () {
                    isChecked.call(_self)
                });
                
                content = document.createElement('p');
                content.innerHTML = this._content;
                
                item.appendChild(checkbox);
                item.appendChild(content);
                if (!(document.getElementById(item.id))) {
                    parent.insertBefore(item, parent.lastChild);
                }
            }
        };
        
        return Item;
    })();
    return Item;
});