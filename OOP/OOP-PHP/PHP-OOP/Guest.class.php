<?php

class Guest {
private $fName;
private $lName;
private $id;

    function __construct($fName,$lName,$id)
    {
        $this->fName = $fName;
        $this->lName = $lName;
        $this->id = $id;
    }

    /**
     * @param string $fName
     */
    public function setFName($fName)
    {
        $this->fName = $fName;
    }

    /**
     * @return string
     */
    public function getFName()
    {
        return $this->fName;
    }

    /**
     * @param string $lName
     */
    public function setLName($lName)
    {
        $this->lName = $lName;
    }

    /**
     * @return string
     */
    public function getLName()
    {
        return $this->lName;
    }

    /**
     * @param long $id
     */
    public function setId($id)
    {
        $this->id = $id;
    }

    /**
     * @return long
     */
    public function getId()
    {
        return $this->id;
    }

    function __toString()
    {
        return $this->fName . $this->lName .  " -  EGN: " . $this->id;
    }

} 