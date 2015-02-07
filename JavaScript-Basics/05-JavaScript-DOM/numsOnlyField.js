function check(){
    var field = document.getElementById('num');
    var inputValue = field.value;
    if (isNaN(inputValue)) {
        var field = document.getElementById('num');
        field.style.backgroundColor = 'red';
        field.disabled = true;
        setTimeout(function (){	field.style.backgroundColor = 'transparent';
            field.disabled = false;
            field.value=0;
            field.focus()}, 2000);

    }
}