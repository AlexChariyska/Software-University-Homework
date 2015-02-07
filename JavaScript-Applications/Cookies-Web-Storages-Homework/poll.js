document.onload = (function () {
    var button = document.getElementById('submit');
    var time;
    var questions = document.getElementsByTagName('H3');


    function setAnswers(questions) {
        for (var i = 0; i < questions.length; i++) {
            var key = questions[i];

            var radios = document.getElementsByClassName('q' + i);
            for (var x = 0, len = radios.length; x < len; x++) {
                if (radios[x].checked) {
                    val = radios[x].id.charAt(0).toUpperCase() + radios[x].id.substr(1) + " " + radios[x].value;
                    localStorage.setItem(key.textContent, val);
                }
            }
        }
    }


    // Countdown 5 minutes
    var sec = 60;   // set the seconds
    var min = 4;   // set the minutes


    var interval = setInterval(function () {
        countDown();
    }, 1000);

    function countDown() {
        sec--;
        if (sec == -01) {
            sec = 59;
            min = min - 1;
        }
        else {
            min = min;
        }
        if (sec == 0 && min == 0) {
            button.click();
            stopInterval();
        }

        time = min + ":" + sec;
        document.getElementById('timer').innerHTML = time;

    }

    function stopInterval() {
        clearInterval(interval);
    }

    function showResults() {
        document.getElementById('results').innerHTML = "<h1>Results<h1>";
        for (var i = 0; i < questions.length; i++) {
            for (var i = 0; i < questions.length; i++) {
                var key = questions[i];
                document.getElementById('results').innerHTML += key.textContent + ' => Your answer was: ' + localStorage.getItem(key.textContent) + "<br/>";
            }
        }
    };

    button.addEventListener('click', function (e) {
        setAnswers(questions);
        stopInterval();
        showResults();
        // Disables button so that after once send, the answers can not be changed
        button.disabled = true;
        localStorage.clear();
    })

    var interval = setInterval(function () {
        setAnswers(questions);
    }, 1000);

    function checkFirstVisit() {
        if (document.cookie.indexOf('myCookies') == -1) {
            document.cookie = 'myCookies=1';
        }
        else {
            for (var i = 0; i < questions.length; i++) {
                var key = questions[i];
                var id = localStorage.getItem(key.textContent).split(/\s+/)[0];
                var searched = id.charAt(0).toLowerCase() + id.substr(1);
                document.getElementById(searched).checked = true;
            }
        }
    }

    checkFirstVisit();
}());