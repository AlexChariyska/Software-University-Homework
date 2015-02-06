<html>
<head>
    <title>CV Generator</title>
    <style>
        input::not input[type="radio"] {
            width: 120px;
        }
        a{
            text-decoration: none;
            color: black;
        }
    </style>
</head>
<body>
<?php
session_start();
?>
<script>
    var nextId = 0;

    function addProgrLang() {
        nextId++;
        var inputDiv = document.createElement("div");
        inputDiv.setAttribute("id", "num" + nextId);
        inputDiv.innerHTML =
            "<input name=\"programmingLanguages[]\">" +
                "    <select name=\"programmingLanguageLevels[]\">" + +
                "<option value=\"Beginner\">Beginner</option>" +
                "<option value=\"Advanced\">Advanced</option>" +
                "<option value=\"Expert\">Expert</option>" +
                "<option value=\"Ninja\">Ninja</option>" +
                "</select>";
        document.getElementById('wrap').appendChild(inputDiv);
    }

    function removeProgrLang() {
        var inputDiv = document.getElementById("wrap").lastChild;
        document.getElementById('wrap').removeChild(inputDiv);
    }

    function addOtherLang() {
        nextId++;
        var inputDiv = document.createElement("div");
        inputDiv.setAttribute("id", "otherLang" + nextId);
        inputDiv.innerHTML =
            "<input name=\"languages[]\" type=\"text\" maxlength=\"20\">" +
                "<select name=\"comprehension[]\">" +
                "<option value=\"-\">-Comprehension-</option>" +
                "<option value=\"Good\">Good</option>" +
                "<option value=\"Excellent\">Excellent</option>" +
                "<option value=\"Advanced\">Advanced</option></select>" +
                "<select name=\"reading[]\"><option value=\"-\">-Reading-</option><option value=\"Good\">Good</option><option value=\"Advanced\">Advanced</option>" +
                "<option value=\"Excellent\">Excellent</option>" +
                "</select><select name=\"writing[]\"><option value=\"-\">-Writing-</option><option value=\"Good\">Good</option>" +
                "<option value=\"Advanced\">Advanced</option>" +
                "<option value=\"Excellent\">Excellent</option>" +
                "</select>";
        document.getElementById('otherLangWrap').appendChild(inputDiv);
    }

    function removeOtherLang() {
        var inputDiv = document.getElementById("otherLangWrap").lastChild;
        document.getElementById('otherLangWrap').removeChild(inputDiv);
    }


</script>
<form action="generator.php" method="POST">
    <fieldset>
        <legend>Personal information</legend>
        <input name="fname" type="text" placeholder="First Name" pattern="[A-Za-zА-яа-я]{2,20}"><br/>
        <input name="lname" type="text" placeholder="Last Name" pattern="[A-Za-zА-яа-я]{2,20}"><br/>
        <input name="email" type="email" placeholder="Email"><br/>
        <input name="phone" type="text" placeholder="Phone Number"><br/>
        Female <input type="radio" value="Female" name="gender">Male<input type="radio" value="Male" name="gender">
        <br/>
        Birth Date <br/>
        <input type="date" name="bDate">
        <br/>Nationality
        <select name="nationality">
            <option value="Bulgarian">Bulgarian</option>
            <option value="American">American</option>
        </select>
    </fieldset>
    <fieldset>
        <legend>Last Work Position</legend>
        Company name:
        <input name="company" type="text"><br/>
        From <input type="date" name="dateWorkStart"><br/>
        To <input type="date" name="dateWorkEnd">
    </fieldset>
    <fieldset>
        <legend>Computer Skills</legend>
        Programing languages:
        <div id="wrap">
        </div>
        <button name="removeLangPr">
            <a href="javascript:removeProgrLang()">Remove Language</a>
        </button>
        <button name="addLangPr">
            <script>addProgrLang();</script>
            <a href="javascript:addProgrLang()">Add Language</a>
        </button>
    </fieldset>
    <fieldset>
        <legend>Other Skills</legend>
        Languages
        <div id="otherLangWrap"></div>
        <button name="removeLang"><a href="javascript:removeOtherLang()">Remove Language</a></button>
        <button name="addLang">
            <script>addOtherLang();</script>
            <a href="javascript:addOtherLang()">Add Language</a></button>
        <br/>
        Driver's license
        <label for="b">B</label> <input id='b' name="licenses" value="B" type="radio">
        <label for="a">A</label> <input id="a" name="licenses" value="A" type="radio">
        <label for="c">C</label> <input id="c" name="licenses" value="C" type="radio">
    </fieldset>
    <button type="submit" name="btn">Generate CV</button>
</form>
</body>
</html>