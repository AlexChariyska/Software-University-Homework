define(['item'],function (Item) {
    'use strict';
    var Section;
    Section = (function () {
        var sectionsCreated = 0;
        
        function Section(title, sectionInput) {
            if (title === "") {
                sectionInput.placeholder = "Section title cannot be empty !!!";
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
                var item = new Item(itemContent.value, itemContent);
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
    }());
    return Section;
})