<?php
require_once "Room.class.php";

class Apartment extends Room {
    const BEDS = 4;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber,Bedroom::BEDS, $price, true, true, RoomType::DIAMOND,"TV, air-conditioner, refrigerator, kitchen box, mini-bar, bathtub, free Wi-fi");
    }

    function __toString()
    {
        return parent::__toString();
    }
} 