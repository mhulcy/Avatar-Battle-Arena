using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Specialized;
using System.Security.Cryptography;

public enum currentState
{
    TITLE,
    BUY,
    COMBAT,
    END
}

public class NewStateMachine : MonoBehaviour
{
    private int prevScene;
   

    private GameObject[] enemyArray;
    private GameObject[] playerArray;
    //private GameObject[] playersOnBoard;
    private int enemyHP = 100;
    private int playerHP = 100;

    public currentState state;

    // Start is called before the first frame update
    void Start()
    {
       
        print("in start");
        state = currentState.BUY;
       // SceneManager.LoadScene(0);

    }


    // Update is called once per frame
    
    void Update()
    {
       // print(state);
        if (state == currentState.COMBAT)
        {
            turnOnCombat();  
            isCombatOver();
        }

        if(state == currentState.BUY)
        {

        }


        if(state == currentState.END)
        {
            print("THE GAME IS OVER");
        }
    }
    

    public void turnOnCombat()
    {

        enemyArray = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        playerArray = GameObject.FindGameObjectsWithTag("Player_Piece");

        for (int i = 0; i < enemyArray.Length; ++i)
        {
            if (enemyArray[i].GetComponent<Warrior_Enemy>() != null)
            {
                Warrior_Enemy instance = enemyArray[i].GetComponent<Warrior_Enemy>();
                instance.isCombat();
            }
            else if (enemyArray[i].GetComponent<Assasin_Enemy>() != null)
            {
                Assasin_Enemy instance = enemyArray[i].GetComponent<Assasin_Enemy>();
                instance.isCombat();
            }
            else if (enemyArray[i].GetComponent<FireBenderEnemy>() != null)
            {
                FireBenderEnemy instance = enemyArray[i].GetComponent<FireBenderEnemy>();
                instance.isCombat();
            }
            else if (enemyArray[i].GetComponent<WaterBender_Enemy>() != null)
            {
                WaterBender_Enemy instance = enemyArray[i].GetComponent<WaterBender_Enemy>();
                instance.isCombat();
            }
            else if (enemyArray[i].GetComponent<EarthBender_Enemy>() != null)
            {
                EarthBender_Enemy instance = enemyArray[i].GetComponent<EarthBender_Enemy>();
                instance.isCombat();
            }
            else if (enemyArray[i].GetComponent<Airbender_Enemy>() != null)
            {
                Airbender_Enemy instance = enemyArray[i].GetComponent<Airbender_Enemy>();
                instance.isCombat();
            }
        }

        for (int i = 0; i < playerArray.Length; ++i)
        {
            if (playerArray[i].GetComponent<AirBender>() != null)
            {
                AirBender instance = playerArray[i].GetComponent<AirBender>();
                instance.isCombat();
            }
            else if (playerArray[i].GetComponent<Assasin>() != null)
            {
                Assasin instance = playerArray[i].GetComponent<Assasin>();
                instance.isCombat();
            }
            else if (playerArray[i].GetComponent<EarthBender>() != null)
            {
                EarthBender instance = playerArray[i].GetComponent<EarthBender>();
                instance.isCombat();
            }
            else if (playerArray[i].GetComponent<FireBender>() != null)
            {
                FireBender instance = playerArray[i].GetComponent<FireBender>();
                instance.isCombat();
            }
            else if (playerArray[i].GetComponent<Warrior>() != null)
            {
                Warrior instance = playerArray[i].GetComponent<Warrior>();
                instance.isCombat();
            }
            else if (playerArray[i].GetComponent<WaterBender>() != null)
            {
                WaterBender instance = playerArray[i].GetComponent<WaterBender>();
                instance.isCombat();
            }
        }



    }

    public void turnOffCombat()
    {
      
    }

    void beginCombat()
    {
        
    }

    void isCombatOver()
    {

       // print("checking if combat is over");
        bool onBoard = false;
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        playerArray = GameObject.FindGameObjectsWithTag("Player_Piece");



        for (int i = 0; i < playerArray.Length; ++i)
        {
            PlayerController instance = playerArray[i].GetComponent<PlayerController>();
            if (!instance.playerBench)
            {
                print("player is on board");
                onBoard = true;
            }



            if (enemyArray.Length == 0)
            {
                //print("ended due to enemies");
                calculateDamage(1);

                
            }
            else if (!onBoard)
            {
                calculateDamage(2);

            }

            if (playerHP <= 0)
            {
                SceneManager.LoadScene(3);
                setStateEnd();
            } else if (enemyHP <= 0)
            {
                SceneManager.LoadScene(4);
                setStateEnd();
            }
        }
    }

    void setStateEnd()
    {
        state = currentState.END;
    }
    void calculateDamage(int winner)
    {
        //Determine whether the object at index 0 is a player or enemy
         if(winner == 1) 
        {
            print("enemy HP: " + enemyHP);
            enemyHP -= 10;
        }
        else
        {
            playerHP -= 10;
            print("Player HP: " + playerHP);
        }
        state = currentState.BUY;
    }

    public void setStateCombat()
    {
        print("Inside set state combat");
        state = currentState.COMBAT;
    }
    public void PlayGame()
    {
        //print("play game");
        prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
    }

    public void GoToContols()
    {
        //print("Go to controls");
        prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }

    public void GoBack()
    {
        //print("go back");
        SceneManager.LoadScene("Board");
    }

   public currentState getState()
    {
        return state;
    }




}
