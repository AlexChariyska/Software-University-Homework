<?php


class BookingManager
{

    public static function bookRoom(Room $room, Reservation $reservation)
    {
        try {
            $room->addReservation($reservation);
            echo "\nRoom <strong>" . $room->getRoomNumber() . "</strong> successfully booked for <strong>"
                . $reservation->getGuest()->getFName() . " " . $reservation->getGuest()->getLName()
                . "</strong> from <time>" . $reservation->getStartDate()->format("d-m-y")
                . "</time> to <time>" . $reservation->getEndDate()->format("d-m-y")."</time>";
        } catch (ReservationException $ex) {
            echo PHP_EOL . $ex->getMessage();
        }
    }
} 