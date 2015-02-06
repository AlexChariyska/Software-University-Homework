<?php

require_once "Room.class.php";

class Bedroom extends Room
{
    const BEDS = 2;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, Bedroom::BEDS, $price, true, true, RoomType::GOLD, "TV, Air conditioner,refrigerator, Mini bar, Bathtub");
    }

    function __toString()
    {
        return parent::__toString();
    }
}