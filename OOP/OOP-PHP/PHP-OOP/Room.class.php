<?php
require_once("iReservable.class.php");

abstract class Room implements iReservable
{
    private $reservations = [];
    private $roomType;
    private $hasRestroom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $extras;
    private $price;

    public function __construct($roomNumber, $bedCount, $price, $hasRestroom, $hasBalcony, $roomType, $extras)
    {
        $this->setRoomType($roomType);
        $this->setHasRestroom($hasRestroom);
        $this->setHasBalcony($hasBalcony);
        $this->setBedCount($bedCount);
        $this->setRoomNumber($roomNumber);
        $this->setExtras($extras);
        $this->setPrice($price);
    }


    /**
     * @param mixed int
     */
    public function setPrice($price)
    {
        $this->price = $price;
    }

    /**
     * @return int
     */
    public function getPrice()
    {
        return $this->price;
    }

    /**
     * @param mixed $roomType
     */
    public function setRoomType($roomType)
    {
        $this->roomType = $roomType;
    }

    /**
     * @return mixed
     */
    public function getRoomType()
    {
        return $this->roomType;
    }

    /**
     * @param boolean $hasBalcony
     */
    public function setHasBalcony($hasBalcony)
    {
        $this->hasBalcony = $hasBalcony;
    }

    /**
     * @return boolean
     */
    public function hasBalcony()
    {
        return $this->hasBalcony;
    }

    /**
     * @param int $bedCount
     */
    public function setBedCount($bedCount)
    {
        $this->bedCount = $bedCount;
    }

    /**
     * @return int
     */
    public function getBedCount()
    {
        return $this->bedCount;
    }

    /**
     * @param string $extras
     */
    public function setExtras($extras)
    {
        $this->extras = $extras;
    }

    /**
     * @return string
     */
    public function getExtras()
    {
        return $this->extras;
    }

    /**
     * @param boolean $hasRestroom
     */
    public function setHasRestroom($hasRestroom)
    {
        $this->hasRestroom = $hasRestroom;
    }

    /**
     * @return boolean
     */
    public function getHasRestroom()
    {
        return $this->hasRestroom;
    }

    /**
     * @param int $roomNumber
     */
    public function setRoomNumber($roomNumber)
    {
        $this->roomNumber = $roomNumber;
    }

    /**
     * @return int
     */
    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    /**
     * @param array $reservations
     */
    public function setReservations($reservations)
    {
        $this->reservations = $reservations;
    }

    /**
     * @return array
     */
    public function getReservations()
    {
        return $this->reservations;
    }

    public function __toString()
    {
        $result = "Room number: $this->roomNumber - type: $this->roomType\n";
        foreach ($this->reservations as $reservation) {
            $result .= $reservation->__toString() . PHP_EOL;
        }

        return $result;
    }

    public function addReservation($reservation)
    {
        foreach ($this->reservations as $existingReservation) {
            if (($reservation->getStartDate() >= $existingReservation->getStartDate() &&
                $reservation->getStartDate() <= $existingReservation->getEndDate())
            ) {
                throw new ReservationException($this->roomNumber, $reservation);
            } elseif (($reservation->getEndDate() >= $existingReservation->getStartDate() &&
                $reservation->getEndDate() <= $existingReservation->getEndDate())
            ) {
                throw new ReservationException($this->roomNumber, $reservation);
            }
        }
        $this->reservations[] = $reservation;
    }


    public function removeReservation($reservation)
    {
        if (($key = array_search($reservation, $this->reservations)) !== false) {
            unset($this->reservations[$key]);
        } else {
            throw new ReservationException($this->roomNumber, $reservation);
        }
    }

} 