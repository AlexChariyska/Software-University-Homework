<?php

require_once "Room.class.php";

class SingleRoom extends Room {
    const BEDS = 1;

    public function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, SingleRoom::BEDS, $price, true, false, RoomType::STANDARD,"TV, air-conditioner");
    }

    function __toString()
    {
        return parent::__toString();
    }

}