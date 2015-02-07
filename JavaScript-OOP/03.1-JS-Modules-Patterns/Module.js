'use strict';

var module = (function () {
    var Container = (function () {
        function Container(title) {
            this._title = title;
        }

        Container.prototype.add = function (parent) {
            var wrapper, title, newSection, sectionBtn, sectionInput;

            wrapper = document.createElement('div');
            wrapper.id = 'wrapper';
            title = document.createElement('h1');
            title.innerHTML = this._title;
            wrapper.appendChild(title);


            sectionInput = document.createElement('input');
            sectionInput.placeholder = 'Title of section ...';

            sectionBtn = document.createElement('input');
            sectionBtn.type = 'button';
            sectionBtn.value = 'New Section';

            sectionBtn.addEventListener("click", function () {
                var section = new module.Section(sectionInput.value,sectionInput );
                section.add(document.getElementById('wrapper'));
                sectionInput.value = "";
            });

            newSection = document.createElement('div');
            newSection.id = 'newSection';
            newSection.appendChild(sectionInput);
            newSection.appendChild(sectionBtn);
            wrapper.appendChild(newSection);
            if (!(document.getElementById('wrapper'))) {
                parent.appendChild(wrapper);
            }
        };

        return Container;
    })();

    var Section = (function () {
        var sectionsCreated = 0;

        function Section(title,sectionInput) {
            if (title === "") {
                sectionInput.placeholder="Section title cannot be empty !!!";
                throw Error('The section title cannot be empty');
            }
            this._title = title;
            sectionsCreated++;
        }

        Section.prototype.add = function (parent) {
            var section, title, itemContent, itemBtn, newItem, lastSectionID;

            section = document.createElement('section');
            lastSectionID = document.getElementById('wrapper').lastChild.previousSibling.id;
            section.id = 'section_' + Number(sectionsCreated);

            title = document.createElement('h2');
            title.innerHTML = this._title;
            section.appendChild(title);

            itemContent = document.createElement('input');
            itemContent.placeholder = 'Add item...';

            itemBtn = document.createElement('input');
            itemBtn.type = 'button';
            itemBtn.value = 'Add';

            itemBtn.addEventListener("click", function () {
                var item = new module.Item(itemContent.value, itemContent);
                item.add(document.getElementById(section.id));
                itemContent.value = "";
            });

            newItem = document.createElement('div');
            newItem.id = 'newSection';
            newItem.appendChild(itemContent);
            newItem.appendChild(itemBtn);
            section.appendChild(newItem);

            if (!(document.getElementById(section.id))) {
                parent.insertBefore(section, parent.lastChild);
            }
        };

        return Section;
    })();

    var Item = (function () {

        function Item(content,itemContent) {
            if (content === "") {
                itemContent.placeholder="Item title cannot be empty!";
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

    return {
        Container: Container,
        Section: Section,
        Item: Item
    }
})
();

var listNew = new module.Container('TODO List');
listNew.add(document.body);