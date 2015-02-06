<?php

class ReservationException extends LogicException
{
    function __construct($roomNumber, Reservation $reservation)
    {
        $this->message = "Room " . $roomNumber . " is already occupied for the period "
            . $reservation->getStartDate()->format("d-m-y") . " - "
            . $reservation->getEndDate()->format("d-m-y") . PHP_EOL;
    }
} 