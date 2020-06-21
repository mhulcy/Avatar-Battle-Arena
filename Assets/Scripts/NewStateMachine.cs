using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public GameObject enemyAirBender;
    public GameObject enemyAirAssasin;
    public GameObject enemyAirWarrior;
    public GameObject enemyEarthWarrior;
    public GameObject enemyEarthBender;
    public GameObject enemyEarthAssasin;
    public GameObject enemyWaterWarrior;
    public GameObject enemyWaterBender;
    public GameObject enemyWaterAssasin;
    public GameObject enemyFireWarrior;
    public GameObject enemyFireAssasin;
    public GameObject enemyFireBender;

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
        //print("update");
        if (state == currentState.COMBAT)
        {
            turnOnCombat();  
            isCombatOver();
        }

        if(state == currentState.END)
        {
            print("THE GAME IS OVER");
        }
    }
    

    void turnOnCombat()
    {
        print("turning on combat");
        Airbender_Enemy airEnemy = enemyAir.GetComponent<Airbender_Enemy>();
        airEnemy.isCombat();
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
        print("play game");
        prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
    }

    public void GoToContols()
    {
        print("Go to controls");
        prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }

    public void GoBack()
    {
        print("go back");
        SceneManager.LoadScene(prevScene);
    }

   public currentState getState()
    {
        return state;
    }




}
