define(['section'],function (Section) {
    'use strict';
    var Container;
    Container = (function () {
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
                var section = new Section(sectionInput.value, sectionInput);
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
    }());
    return Container;
});