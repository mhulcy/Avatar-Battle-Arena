using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Specialized;
using System.Security.Cryptography;


public class ShopRefresher   : MonoBehaviour 
{
     public GameObject buttons;
     public void Start()
    {
         FireWarriorOne.SetActive(false);
         FireWarriorTwo.SetActive(false);
         FireWarriorThree.SetActive(false);
         FireWarriorFour.SetActive(false);
         FireWarriorFive.SetActive(false);
         FireAssassinOne.SetActive(false);
         FireAssassinTwo.SetActive(false);
         FireAssassinThree.SetActive(false);
         FireAssassinFour.SetActive(false);
         FireAssassinFive.SetActive(false);
         FireBenderOne.SetActive(false);
         FireBenderTwo.SetActive(false);
         FireBenderThree.SetActive(false);
         FireBenderFour.SetActive(false);
         FireBenderFive.SetActive(false);
         WaterWarriorOne.SetActive(false);
         WaterWarriorTwo.SetActive(false);
         WaterWarriorThree.SetActive(false);
         WaterWarriorFour.SetActive(false);
         WaterWarriorFive.SetActive(false);
         WaterAssassinOne.SetActive(false);
         WaterAssassinTwo.SetActive(false);
         WaterAssassinThree.SetActive(false);
         WaterAssassinFour.SetActive(false); 
         WaterAssassinFive.SetActive(false);
         WaterBenderOne.SetActive(false);
         WaterBenderTwo.SetActive(false);
         WaterBenderThree.SetActive(false);
         WaterBenderFour.SetActive(false);
         WaterBenderFive.SetActive(false);
         EarthWarriorOne.SetActive(false);
         EarthWarriorTwo.SetActive(false);
         EarthWarriorThree.SetActive(false);
         EarthWarriorFour.SetActive(false);
         EarthWarriorFive.SetActive(false);
         EarthAssassinOne.SetActive(false);
         EarthAssassinTwo.SetActive(false);
         EarthAssassinThree.SetActive(false);
         EarthAssassinFour.SetActive(false);
         EarthAssassinFive.SetActive(false);
         EarthBenderOne.SetActive(false);
         EarthBenderTwo.SetActive(false);
         EarthBenderThree.SetActive(false);
         EarthBenderFour.SetActive(false);
         EarthBenderFive.SetActive(false);
         AirWarriorOne.SetActive(false);
         AirWarriorTwo.SetActive(false);
         AirWarriorThree.SetActive(false);
         AirWarriorFour.SetActive(false);
         AirWarriorFive.SetActive(false);
         AirAssassinOne.SetActive(false);
         AirAssassinTwo.SetActive(false);
         AirAssassinThree.SetActive(false);
         AirAssassinFour.SetActive(false);
         AirAssassinFive.SetActive(false);
         AirBenderOne.SetActive(false);
         AirBenderTwo.SetActive(false);
         AirBenderThree.SetActive(false);
         AirBenderFour.SetActive(false);
         AirBenderFive.SetActive(false);
        int number = (int)(UnityEngine.Random.Range(1f, 100f));
        int caseSwitch = 0;
        if (number >= 1 && number <= 10)
            caseSwitch = 1;
        if (number >= 11 && number <= 20)
            caseSwitch = 2;
        if (number >= 21 && number <= 30)
            caseSwitch = 3;
        if (number >= 31 && number <= 40)
            caseSwitch = 4;
        if (number >= 41 && number <= 50)
            caseSwitch = 5;
        if (number >= 51 && number <= 60)
            caseSwitch = 6;
        if (number >= 61 && number <= 70)
            caseSwitch = 7;
        if (number >= 71 && number <= 80)
            caseSwitch = 8;
        if (number >= 81 && number <= 85)
            caseSwitch = 9;
        if (number >= 86 && number <= 90)
            caseSwitch = 10;
        if (number >= 91 && number <= 95)
            caseSwitch = 11;
        if (number >= 96 && number <= 100)
            caseSwitch = 12;
        switch (caseSwitch)
        {
            case 1:
        FireWarriorOne.SetActive(true);
                break;
            case 2:
        FireAssassinOne.SetActive(true);
                break;
            case 3:
        FireBenderOne.SetActive(true);
                break;
            case 4:
        WaterWarriorOne.SetActive(true);
                break;
            case 5:
        WaterAssassinOne.SetActive(true);
                break;
            case 6:
        WaterBenderOne.SetActive(true);
                break;
            case 7:
        EarthWarriorOne.SetActive(true);
                break;
            case 8:
        EarthAssassinOne.SetActive(true);
                break;
            case 9:
        EarthBenderOne.SetActive(true);
                break;
            case 10:
        AirWarriorOne.SetActive(true);
                break;
            case 11:
        AirAssassinOne.SetActive(true);
                break;
            case 12:
        AirBenderOne.SetActive(true);
                break;
        }
        int number2 = (int)(UnityEngine.Random.Range(1f, 100f));
        int caseSwitch2 = 0;
        if (number2 >= 1 && number2 <= 10)
            caseSwitch2 = 1;
        if (number2 >= 11 && number2 <= 20)
            caseSwitch2 = 2;
        if (number2 >= 21 && number2 <= 30)
            caseSwitch2 = 3;
        if (number2 >= 31 && number2 <= 40)
            caseSwitch2 = 4;
        if (number2 >= 41 && number2 <= 50)
            caseSwitch2 = 5;
        if (number2 >= 51 && number2 <= 60)
            caseSwitch2 = 6;
        if (number2 >= 61 && number2 <= 70)
            caseSwitch2 = 7;
        if (number2 >= 71 && number2 <= 80)
            caseSwitch2 = 8;
        if (number2 >= 81 && number2 <= 85)
            caseSwitch2 = 9;
        if (number2 >= 86 && number2 <= 90)
            caseSwitch2 = 10;
        if (number2 >= 91 && number2 <= 95)
            caseSwitch2 = 11;
        if (number2 >= 96 && number2 <= 100)
            caseSwitch2 = 12;
        switch (caseSwitch2)
        {
            case 1:
                FireWarriorTwo.SetActive(true);
                break;
            case 2:
                FireAssassinTwo.SetActive(true);
                break;
            case 3:
                FireBenderTwo.SetActive(true);
                break;
            case 4:
                WaterWarriorTwo.SetActive(true);
                break;
            case 5:
                WaterAssassinTwo.SetActive(true);
                break;
            case 6:
                WaterBenderTwo.SetActive(true);
                break;
            case 7:
                EarthWarriorTwo.SetActive(true);
                break;
            case 8:
                EarthAssassinTwo.SetActive(true);
                break;
            case 9:
                EarthBenderTwo.SetActive(true);
                break;
            case 10:
                AirWarriorTwo.SetActive(true);
                break;
            case 11:
                AirAssassinTwo.SetActive(true);
                break;
            case 12:
                AirBenderTwo.SetActive(true);
                break;
        }
        int number3 = (int)(UnityEngine.Random.Range(1f, 100f));
        int caseSwitch3 = 0;
        if (number3 >= 1 && number3 <= 10)
            caseSwitch3 = 1;
        if (number3 >= 11 && number3 <= 20)
            caseSwitch3 = 2;
        if (number3 >= 21 && number3 <= 30)
            caseSwitch3 = 3;
        if (number3 >= 31 && number3 <= 40)
            caseSwitch3 = 4;
        if (number3 >= 41 && number3 <= 50)
            caseSwitch3 = 5;
        if (number3 >= 51 && number3 <= 60)
            caseSwitch3 = 6;
        if (number3 >= 61 && number3 <= 70)
            caseSwitch3 = 7;
        if (number3 >= 71 && number3 <= 80)
            caseSwitch3 = 8;
        if (number3 >= 81 && number3 <= 85)
            caseSwitch3 = 9;
        if (number3 >= 86 && number3 <= 90)
            caseSwitch3 = 10;
        if (number3 >= 91 && number3 <= 95)
            caseSwitch3 = 11;
        if (number3 >= 96 && number3 <= 100)
            caseSwitch3 = 12;
        switch (caseSwitch3)
        {
            case 1:
                FireWarriorThree.SetActive(true);
                break;
            case 2:
                FireAssassinThree.SetActive(true);
                break;
            case 3:
                FireBenderThree.SetActive(true);
                break;
            case 4:
                WaterWarriorThree.SetActive(true);
                break;
            case 5:
                WaterAssassinThree.SetActive(true);
                break;
            case 6:
                WaterBenderThree.SetActive(true);
                break;
            case 7:
                EarthWarriorThree.SetActive(true);
                break;
            case 8:
                EarthAssassinThree.SetActive(true);
                break;
            case 9:
                EarthBenderThree.SetActive(true);
                break;
            case 10:
                AirWarriorThree.SetActive(true);
                break;
            case 11:
                AirAssassinThree.SetActive(true);
                break;
            case 12:
                AirBenderThree.SetActive(true);
                break;
        }
        int number4 = (int)(UnityEngine.Random.Range(1f, 100f));
        int caseSwitch4 = 0;
        if (number4 >= 1 && number4 <= 10)
            caseSwitch4 = 1;
        if (number4 >= 11 && number4 <= 20)
            caseSwitch4 = 2;
        if (number4 >= 21 && number4 <= 30)
            caseSwitch4 = 3;
        if (number4 >= 31 && number4 <= 40)
            caseSwitch4 = 4;
        if (number4 >= 41 && number4 <= 50)
            caseSwitch4 = 5;
        if (number4 >= 51 && number4 <= 60)
            caseSwitch4 = 6;
        if (number4 >= 61 && number4 <= 70)
            caseSwitch4 = 7;
        if (number4 >= 71 && number4 <= 80)
            caseSwitch4 = 8;
        if (number4 >= 81 && number4 <= 85)
            caseSwitch4 = 9;
        if (number4 >= 86 && number4 <= 90)
            caseSwitch4 = 10;
        if (number4 >= 91 && number4 <= 95)
            caseSwitch4 = 11;
        if (number4 >= 96 && number4 <= 100)
            caseSwitch4 = 12;
        switch (caseSwitch4)
        {
            case 1:
                FireWarriorFour.SetActive(true);
                break;
            case 2:
                FireAssassinFour.SetActive(true);
                break;
            case 3:
                FireBenderFour.SetActive(true);
                break;
            case 4:
                WaterWarriorFour.SetActive(true);
                break;
            case 5:
                WaterAssassinFour.SetActive(true);
                break;
            case 6:
                WaterBenderFour.SetActive(true);
                break;
            case 7:
                EarthWarriorFour.SetActive(true);
                break;
            case 8:
                EarthAssassinFour.SetActive(true);
                break;
            case 9:
                EarthBenderFour.SetActive(true);
                break;
            case 10:
                AirWarriorFour.SetActive(true);
                break;
            case 11:
                AirAssassinFour.SetActive(true);
                break;
            case 12:
                AirBenderFour.SetActive(true);
                break;
        }
        int number5 = (int)(UnityEngine.Random.Range(1f, 100f));
        int caseSwitch5 = 0;
        if (number5 >= 1 && number5 <= 10)
            caseSwitch5 = 1;
        if (number5 >= 11 && number5 <= 20)
            caseSwitch5 = 2;
        if (number5 >= 21 && number5 <= 30)
            caseSwitch5 = 3;
        if (number5 >= 31 && number5 <= 40)
            caseSwitch5 = 4;
        if (number5 >= 41 && number5 <= 50)
            caseSwitch5 = 5;
        if (number5 >= 51 && number5 <= 60)
            caseSwitch5 = 6;
        if (number5 >= 61 && number5 <= 70)
            caseSwitch5 = 7;
        if (number5 >= 71 && number5 <= 80)
            caseSwitch5 = 8;
        if (number5 >= 81 && number5 <= 85)
            caseSwitch5 = 9;
        if (number5 >= 86 && number5 <= 90)
            caseSwitch5 = 10;
        if (number5 >= 91 && number5 <= 95)
            caseSwitch5 = 11;
        if (number5 >= 96 && number4 <= 100)
            caseSwitch5 = 12;
        switch (caseSwitch5)
        {
            case 1:
                FireWarriorFive.SetActive(true);
                break;
            case 2:
                FireAssassinFive.SetActive(true);
                break;
            case 3:
                FireBenderFive.SetActive(true);
                break;
            case 4:
                WaterWarriorFive.SetActive(true);
                break;
            case 5:
                WaterAssassinFive.SetActive(true);
                break;
            case 6:
                WaterBenderFive.SetActive(true);
                break;
            case 7:
                EarthWarriorFive.SetActive(true);
                break;
            case 8:
                EarthAssassinFive.SetActive(true);
                break;
            case 9:
                EarthBenderFive.SetActive(true);
                break;
            case 10:
                AirWarriorFive.SetActive(true);
                break;
            case 11:
                AirAssassinFive.SetActive(true);
                break;
            case 12:
                AirBenderFive.SetActive(true);
                break;
        }

    }
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

}
