<?php
function __autoload($className)
{
    include_once($className . ".class.php");
}

$guest = new Guest("Anna", "Ivanova", 1213456789);
$guest2 = new Guest("Mitko", "Mitev", 1111885452);
$guest3 = new Guest("Pesho", "Petrov", 2220566466);


$firstReservation = new Reservation("01-10-2014", "05-10-2014", $guest);
$secondReservation = new Reservation("08-10-2014", "25-10-2014", $guest2);
$thirdReservation = new Reservation("13-09-2014", "14-10-2014", $guest3);
$fourReservation = new Reservation("01-10-2014", "17-10-2014", $guest2);

$rooms[201] = new SingleRoom(111, 40);
BookingManager::bookRoom($rooms[201], $firstReservation);
BookingManager::bookRoom($rooms[201], $fourReservation);

$rooms[305] = new SingleRoom(305, 60);
BookingManager::bookRoom($rooms[305], $firstReservation);
BookingManager::bookRoom($rooms[305], $secondReservation);

$rooms[401] = new SingleRoom(411, 90);
$rooms[412] = new Bedroom(412, 70);
$rooms[302] = new Bedroom(315, 80);
$rooms[202] = new Bedroom(202, 70);
$rooms[410] = new Bedroom(110, 80);

$rooms[501] = new Apartment(501, 200);
BookingManager::bookRoom($rooms[501], $secondReservation);

$rooms[601] = new Apartment(502, 300);
$rooms[601] = new Apartment(601, 350);

echo PHP_EOL;
echo "Bedrooms and apartments with a price less or equal to 250.00$:";
echo PHP_EOL;

$filteredRooms = array_filter($rooms, "roomsByPrice");
function roomsByPrice(Room $room)
{
    if (($room instanceof Bedroom) || ($room instanceof Apartment)) {
        if ($room->getPrice() <= 250) {
            return true;
        }
    }
    return false;
}

foreach ($filteredRooms as $room) {
    echo "{$room->getRoomNumber()} - {$room->getRoomType()} - {$room->getPrice()}" . PHP_EOL;
}

echo PHP_EOL;
echo "Rooms with a balcony:";
echo PHP_EOL;

$filteredRoomsWithBalcony = array_filter($rooms, "roomsWithBalcony");
function roomsWithBalcony(Room $room)
{
    if ($room->hasBalcony()) {
        return true;
    }

    return false;
}

foreach ($filteredRoomsWithBalcony as $room) {
    echo "{$room->getRoomNumber()} - {$room->getRoomType()} - {$room->hasBalcony()}" . PHP_EOL;
}

echo PHP_EOL;
echo "Room numbers which have a bathtub";
echo PHP_EOL;

$filteredRoomsWithBathtub = array_filter($rooms, "roomsWithBathtub");
$roomNumbers = array_map("returnRoomNumbers", $filteredRoomsWithBathtub);
function roomsWithBathtub(Room $room)
{
    if (strpos($room->getExtras(), 'bathtub') !== false) {
        return true;
    }

    return false;
}

function returnRoomNumbers($room)
{
    return $room->getRoomNumber();
}

foreach ($roomNumbers as $roomNumber) {
    echo $roomNumber . PHP_EOL;
}
