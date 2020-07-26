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

    private Vector3[] playerPositions;
    private Vector3[] enemyPositions;
    private GameObject[] enemyArray;
    private GameObject[] playerArray;
    //private GameObject[] playersOnBoard;
    private int enemyHP = 100;
    private int playerHP = 100;

    public currentState state;

    // Start is called before the first frame update
    void Start()
    {
        bool begin = true;
        print("in start");
        state = currentState.BUY;
       // SceneManager.LoadScene(0);

    }


    // Update is called once per frame
    
    void Update()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        playerArray = GameObject.FindGameObjectsWithTag("Player_Piece");
        // print(state);
        if (state == currentState.COMBAT)
        {
            if (playerArray.Length > 0)
            {
                turnOnCombat();
            }
            isCombatOver();
        }

        if(state == currentState.BUY)
        {
            enemyPositions = enemyRecordPositions();
            playerPositions = playerRecordPositions();
        }


        if(state == currentState.END)
        {
            print("THE GAME IS OVER");
        }
    }
    

    Vector3[] enemyRecordPositions()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        Vector3[] enemyPositions = new Vector3[enemyArray.Length];
        for (int i = 0; i < enemyArray.Length; ++i)
        {
                enemyPositions[i] = enemyArray[i].transform.position;
           // print(enemyPositions[i]);
        }
        return enemyPositions;
    }


    Vector3[]  playerRecordPositions()
    {
        playerArray = GameObject.FindGameObjectsWithTag("Player_Piece");
        Vector3[] playerPositions = new Vector3[playerArray.Length];
        for(int i = 0; i < playerArray.Length;++i)
        {
            PlayerController instance = playerArray[i].GetComponent<PlayerController>();
            if (!instance.playerBench)
            {
                playerPositions[i] = playerArray[i].transform.position;
            }
        }
        return playerPositions;
    }

    void destroyPlayers()
    {
        print("destroying players");
        playerArray = GameObject.FindGameObjectsWithTag("Player_Piece");
        for(int i = 0; i < playerArray.Length; ++i)
        {
            PlayerController instance = playerArray[i].GetComponent<PlayerController>();
            if (!instance.playerBench)
            {
                Destroy(playerArray[i]);
            }
        }
    }

    void destroyEnemy()
    {
        print("destorying enemies");
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        for(int i = 0; i < enemyArray.Length; ++i)
        {
            Destroy(enemyArray[i]);
        }
    }




    public void turnOffCombat()
    {

        enemyArray = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        playerArray = GameObject.FindGameObjectsWithTag("Player_Piece");

        for (int i = 0; i < enemyArray.Length; ++i)
        {
            if (enemyArray[i].GetComponent<Warrior_Enemy>() != null)
            {
                Warrior_Enemy instance = enemyArray[i].GetComponent<Warrior_Enemy>();
                instance.notCombat();
            }
            else if (enemyArray[i].GetComponent<Assasin_Enemy>() != null)
            {
                Assasin_Enemy instance = enemyArray[i].GetComponent<Assasin_Enemy>();
                instance.notCombat();
            }
            else if (enemyArray[i].GetComponent<FireBenderEnemy>() != null)
            {
                FireBenderEnemy instance = enemyArray[i].GetComponent<FireBenderEnemy>();
                instance.notCombat();
            }
            else if (enemyArray[i].GetComponent<WaterBender_Enemy>() != null)
            {
                WaterBender_Enemy instance = enemyArray[i].GetComponent<WaterBender_Enemy>();
                instance.notCombat();
            }
            else if (enemyArray[i].GetComponent<EarthBender_Enemy>() != null)
            {
                EarthBender_Enemy instance = enemyArray[i].GetComponent<EarthBender_Enemy>();
                instance.notCombat();
            }
            else if (enemyArray[i].GetComponent<Airbender_Enemy>() != null)
            {
                Airbender_Enemy instance = enemyArray[i].GetComponent<Airbender_Enemy>();
                instance.notCombat();
            }
        }

        for (int i = 0; i < playerArray.Length; ++i)
        {
            if (playerArray[i].GetComponent<AirBender>() != null)
            {
                AirBender instance = playerArray[i].GetComponent<AirBender>();
                instance.notCombat();
            }
            else if (playerArray[i].GetComponent<Assasin>() != null)
            {
                Assasin instance = playerArray[i].GetComponent<Assasin>();
                instance.notCombat();
            }
            else if (playerArray[i].GetComponent<EarthBender>() != null)
            {
                EarthBender instance = playerArray[i].GetComponent<EarthBender>();
                instance.notCombat();
            }
            else if (playerArray[i].GetComponent<FireBender>() != null)
            {
                FireBender instance = playerArray[i].GetComponent<FireBender>();
                instance.notCombat();
            }
            else if (playerArray[i].GetComponent<Warrior>() != null)
            {
                Warrior instance = playerArray[i].GetComponent<Warrior>();
                instance.notCombat();
            }
            else if (playerArray[i].GetComponent<WaterBender>() != null)
            {
                WaterBender instance = playerArray[i].GetComponent<WaterBender>();
                instance.notCombat();
            }
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
                //print("player is on board");
                onBoard = true;
            }

            print(playerArray.Length);
            print(onBoard);

            if (enemyArray.Length == 0)
            {
                //print("ended due to enemies");
                calculateDamage(1);

                
            }
            else if (!onBoard)
            {
                print("enemies won");
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
            destroyPlayers();
        }
        else
        {
            playerHP -= 10;
            print("Player HP: " + playerHP);
            destroyEnemy();
        }

        turnOffCombat();
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
