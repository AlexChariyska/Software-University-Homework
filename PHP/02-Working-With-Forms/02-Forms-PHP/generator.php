<?php
session_start();
if (isset($_POST['btn'])) {
    $_SESSION["firstName"] = htmlentities($_POST['fname']);
    $_SESSION["lastName"] = htmlentities($_POST['lname']);
    $_SESSION["email"] = htmlentities($_POST['email']);
    $_SESSION["phone"] = htmlentities($_POST['phone']);
    $_SESSION["gender"] = $_POST['gender'];
    $_SESSION["bDate"] = $_POST['bDate'];
    $_SESSION["nationality"] = $_POST['nationality'];
    $_SESSION["company"] = htmlentities($_POST['company']);
    $_SESSION["dateWorkStart"] = $_POST['dateWorkStart'];
    $_SESSION["dateWorkEnd"] = $_POST['dateWorkEnd'];
    $_SESSION["licenses"] = $_POST['licenses'];

    $_SESSION["programmingLanguages"] = ($_POST['programmingLanguages']);
    $_SESSION["programmingLanguageLevels"] = ($_POST['programmingLanguageLevels']);

    $_SESSION["languages"] = $_POST["languages"];
    $_SESSION["comprehension"] = $_POST["comprehension"];
    $_SESSION["reading"] = $_POST["reading"];
    $_SESSION["writing"] = $_POST["writing"];


    function isValidEmail($email){
        $pattern = "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$^";
        if (preg_match($pattern, $email)){
            return true;
        }
        else {
            return false;
        }
    }
    function isValidPhone($phone){
        $pattern = "/^[0-9 \' \'+-]+$/";
        if (preg_match($pattern, $phone)){
            return true;
        }
        else {
            return false;
        }
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>CV Generator - Result</title>
    <style>
        table, th, tr, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<h1>CV</h1>
<table>
    <thead>
    <tr>
        <th colspan="2">Personal Information</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>First Name</td>
        <td><?php echo $_SESSION["firstName"] ?></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td><?php echo $_SESSION["lastName"] ?></td>
    </tr>
    <tr>
        <td>Email</td>
        <td>
            <?php
            if (isValidEmail($_SESSION["email"])) {
                echo "<strong style=\"color:red\">Invalid email format</strong>";
            } else {
                echo $_SESSION["email"];
            }?>
        </td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td>
           <?php
            if (isValidPhone($_SESSION["phone"])){
                echo $_SESSION["phone"];
            } else {
                echo "<strong style=\"color:red\">Phone is invalid</strong>";
            }
            ?>
        </td>
    </tr>
    <tr>
        <td>Gender</td>
        <td><?php echo $_SESSION["gender"] ?></td>
    </tr>
    <tr>
        <td>Birth Date</td>
        <td>
            <?php
            if (isset($_POST['bDate'])) {
                echo date("d-m-Y", strtotime($_SESSION["bDate"]));
            }
            ?>
        </td>
    </tr>
    <tr>
        <td>Nationality</td>
        <td><?php echo $_SESSION["nationality"] ?></td>
    </tr>
    </tbody>
</table>
<br/>
<table>
    <thead>
    <tr>
        <th colspan="2">Last Work Position</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Company Name</td>
        <td><?php echo $_SESSION["company"] ?></td>
    </tr>
    <tr>
        <td>From</td>
        <td>
            <?php
            echo date("d-m-Y", strtotime($_SESSION["dateWorkStart"]));
            ?>
        </td>
    </tr>
    <tr>
        <td>To</td>
        <td>
            <?php
            echo date("d-m-Y", strtotime($_SESSION["dateWorkEnd"]));
            ?>
        </td>
    </tr>
    </tbody>
</table>
<br/>
<table>
    <thead>
    <tr>
        <th colspan="2">Computer Skills</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Programming Languages</td>
        <td>
            <table>
                <thead>
                <tr>
                    <th>Language</th>
                    <th>Skill Level</th>
                </tr>
                </thead>
                <tbody>
                <?php
                foreach ($_SESSION["programmingLanguages"] as $id => $language) {
                    echo "<tr><td>$language</td><td>{$_SESSION["programmingLanguageLevels"][$id]
                }</td></tr>";
                }
                ?>
                </tbody>
            </table>
        </td>
    </tr>
    </tbody>
</table>
<br/>
<table>
    <thead>
    <tr>
        <th colspan="2">Other Skills</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Languages</td>
        <td>
            <table>
                <thead>
                <tr>
                    <th>Language</th>
                    <th>Comprehension</th>
                    <th>Reading</th>
                    <th>Writing</th>
                </tr>
                </thead>
                <tbody>
                <?php
                foreach ($_SESSION["languages"] as $id => $language) {
                    echo "<tr><td>$language</td><td>{$_SESSION["comprehension"][$id]}</td><td>{$_SESSION["reading"][$id]}</td><td>{$_SESSION["writing"][$id]}</td></tr>";
                }
                ?>
                </tbody>
            </table>
        </td>
    </tr>
    <tr>
        <td>Driver's license</td>
        <td><?php echo $_SESSION["licenses"]; ?></td>
    </tr>
    </tbody>
</table>
</body>
</html>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       