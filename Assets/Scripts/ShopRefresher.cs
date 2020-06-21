using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopRefresher : MonoBehaviour
{

    public GameObject FireWarriorOne;
    public GameObject FireWarriorTwo;
    public GameObject FireWarriorThree;
    public GameObject FireWarriorFour;
    public GameObject FireWarriorFive;
    public GameObject FireAssassinOne;
    public GameObject FireAssassinTwo;
    public GameObject FireAssassinThree;
    public GameObject FireAssassinFour;
    public GameObject FireAssassinFive;
    public GameObject FireBenderOne;
    public GameObject FireBenderTwo;
    public GameObject FireBenderThree;
    public GameObject FireBenderFour;
    public GameObject FireBenderFive;

    public GameObject WaterWarriorOne;
    public GameObject WaterWarriorTwo;
    public GameObject WaterWarriorThree;
    public GameObject WaterWarriorFour;
    public GameObject WaterWarriorFive;
    public GameObject WaterAssassinOne;
    public GameObject WaterAssassinTwo;
    public GameObject WaterAssassinThree;
    public GameObject WaterAssassinFour;
    public GameObject WaterAssassinFive;
    public GameObject WaterBenderOne;
    public GameObject WaterBenderTwo;
    public GameObject WaterBenderThree;
    public GameObject WaterBenderFour;
    public GameObject WaterBenderFive;

    public GameObject EarthWarriorOne;
    public GameObject EarthWarriorTwo;
    public GameObject EarthWarriorThree;
    public GameObject EarthWarriorFour;
    public GameObject EarthWarriorFive;
    public GameObject EarthAssassinOne;
    public GameObject EarthAssassinTwo;
    public GameObject EarthAssassinThree;
    public GameObject EarthAssassinFour;
    public GameObject EarthAssassinFive;
    public GameObject EarthBenderOne;
    public GameObject EarthBenderTwo;
    public GameObject EarthBenderThree;
    public GameObject EarthBenderFour;
    public GameObject EarthBenderFive;

    public GameObject AirWarriorOne;
    public GameObject AirWarriorTwo;
    public GameObject AirWarriorThree;
    public GameObject AirWarriorFour;
    public GameObject AirWarriorFive;
    public GameObject AirAssassinOne;
    public GameObject AirAssassinTwo;
    public GameObject AirAssassinThree;
    public GameObject AirAssassinFour;
    public GameObject AirAssassinFive;
    public GameObject AirBenderOne;
    public GameObject AirBenderTwo;
    public GameObject AirBenderThree;
    public GameObject AirBenderFour;
    public GameObject AirBenderFive;

    int buttonOne;
    int buttonTwo;
    int buttonThree;
    int buttonFour;
    int buttonFive;
    public void resetShop()
    {
        FireWarriorOne = GameObject.Find("FireWarrior");
        FireWarriorOne.Enabled == false;
       /* FireWarriorTwo.Enabled == false;
        FireWarriorThree.Enabled == false;
        FireWarriorFour.Enabled == false;
        FireWarriorFive.Enabled == false;
        FireAssassinOne.Enabled == false;
        FireAssassinTwo.Enabled == false;
        FireAssassinThree.Enabled == false;
        FireAssassinFour.Enabled == false;
        FireAssassinFive.Enabled == false;
        FireBenderOne.Enabled == false;
        FireBenderTwo.Enabled == false;
        FireBenderThree.Enabled == false;
        FireBenderFour.Enabled == false;
        FireBenderFive.Enabled == false;

        WaterWarriorOne.Enabled == false;
        WaterWarriorTwo.Enabled == false;
        WaterWarriorThree.Enabled == false;
        WaterWarriorFour.Enabled == false;
        WaterWarriorFive.Endabled == false;
        WaterAssassinOne.Enabled == false;
        WaterAssassinTwo.Enabled == false;
        WaterAssassinThree.Enabled == false;
        WaterAssassinFour.Enabled == false; 
        WaterAssassinFive.Enabled == false;
        WaterBenderOne.Enabled == false;
        WaterBenderTwo.Enabled == false;
        WaterBenderThree.Enabled == false;
        WaterBenderFour.Enabled == false;
        WaterBenderFive.Enabled == false;

        EarthWarriorOne.Enabled == false;
        EarthWarriorTwo.Enabled == false;
        EarthWarriorThree.Enabled == false;
        EarthWarriorFour.Enabled == false;
        EarthWarriorFive.Enabled == false;
        EarthAssassinOne.Enabled == false;
        EarthAssassinTwo.Enabled == false;
        EarthAssassinThree.Enabled == false;
        EarthAssassinFour.Enabled == false;
        EarthAssassinFive.Enabled == false;
        EarthBenderOne.Enabled == false;
        EarthBenderTwo.Enabled == false;
        EarthBenderThree.Enabled == false;
        EarthBenderFour.Enabled == false;
        EarthBenderFive.Enabled == false;

        AirWarriorOne;
        AirWarriorTwo;
        AirWarriorThree;
        AirWarriorFour;
        AirWarriorFive;
        AirAssassinOne;
        AirAssassinTwo;
        AirAssassinThree;
        AirAssassinFour;
        AirAssassinFive;
        AirBenderOne;
        AirBenderTwo;
        AirBenderThree;
        AirBenderFour;
        AirBenderFive;

    buttonOne = getSwitchCase();
        setButton(buttonOne);
        buttonTwo = getSwitchCase();

        buttonThree = getSwitchCase();

        buttonFour = getSwitchCase();

        buttonFive = getSwitchCase();
       */
    }
    private int getCaseSwich()
    {
        int caseSwitch = 0;
        int pieceNumber = (Random.Next() % 100) + 1;
        if (pieceNumber >= 1 && pieceNumber <= 10)
            caseSwitch = 1;
        if (pieceNumber >= 11 && pieceNumber <= 20)
            caseSwitch = 2;
        if (pieceNumber >= 21 && pieceNumber <= 30)
            caseSwitch = 3;
        if (pieceNumber >= 31 && pieceNumber <= 40)
            caseSwitch = 4;
        if (pieceNumber >= 41 && pieceNumber <= 50)
            caseSwitch = 5;
        if (pieceNumber >= 51 && pieceNumber <= 60)
            caseSwitch = 6;
        if (pieceNumber >= 61 && pieceNumber <= 70)
            caseSwitch = 7;
        if (pieceNumber >= 71 && pieceNumber <= 80)
            caseSwitch = 8;
        if (pieceNumber >= 81 && pieceNumber <= 85)
            caseSwitch = 9;
        if (pieceNumber >= 86 && pieceNumber <= 90)
            caseSwitch = 10;
        if (pieceNumber >= 91 && pieceNumber <= 95)
            caseSwitch = 11;
        if (pieceNumber >= 96 && pieceNumber <= 100)
            caseSwitch = 12;
        return caseSwitch;
    }

    private void setButton(int button)
    {

    }
}
