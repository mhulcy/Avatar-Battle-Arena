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

    public GameObject AirBender;
    public GameObject AirAssasin;
    public GameObject AirWarrior;
    public GameObject EarthWarrior;
    public GameObject EarthBender;
    public GameObject EarthAssasin;
    public GameObject WaterWarrior;
    public GameObject WaterBender;
    public GameObject WaterAssasin;
    public GameObject FireWarrior;
    public GameObject FireAssasin;
    public GameObject FireBender;

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
        Airbender_Enemy airEnemy = enemyAirBender.GetComponent<Airbender_Enemy>();
        AirBender airPlayer = AirBender.GetComponent<AirBender>();
        Assasin airPlayerAssasin = AirAssasin.GetComponent<Assasin>();
        Assasin_Enemy airEnemyAssasin = enemyAirAssasin.GetComponent<Assasin_Enemy>();
        Warrior airWarrior = AirWarrior.GetComponent<Warrior>();
        Warrior_Enemy airWarriorEnemy = enemyAirWarrior.GetComponent<Warrior_Enemy>();
        Assasin earthPlayerAssasin = EarthAssasin.GetComponent<Assasin>();
        Assasin_Enemy earthEnemyAssasin = enemyEarthAssasin.GetComponent<Assasin_Enemy>();
        Warrior earthPlayerWarrior = EarthWarrior.GetComponent<Warrior>();
        Warrior_Enemy earthEnemyWarrior = enemyEarthWarrior.GetComponent<Warrior_Enemy>();
        EarthBender_Enemy earthEnemy = enemyEarthBender.GetComponent<EarthBender_Enemy>();
        EarthBender earthPlayer = EarthBender.GetComponent<EarthBender>();
        Assasin firePlayerAssasin = FireAssasin.GetComponent<Assasin>();
        Assasin_Enemy fireEnemyAssasin = enemyFireAssasin.GetComponent<Assasin_Enemy>();
        Warrior firePlayerWarrior = FireWarrior.GetComponent<Warrior>();
        Warrior_Enemy fireEnemyWarrior = enemyFireWarrior.GetComponent<Warrior_Enemy>();
        FireBenderEnemy fireEnemy = enemyFireBender.GetComponent<FireBenderEnemy>();
        FireBender firePlayer = FireBender.GetComponent<FireBender>();
        Assasin waterPlayerAssasin = WaterAssasin.GetComponent<Assasin>();
        Assasin_Enemy waterEnemyAssasin = enemyWaterAssasin.GetComponent<Assasin_Enemy>();
        Warrior waterPlayerWarrior = WaterWarrior.GetComponent<Warrior>();
        Warrior_Enemy waterEnemyWarrior = enemyWaterWarrior.GetComponent<Warrior_Enemy>();
        WaterBender waterPlayer = WaterBender.GetComponent<WaterBender>();
        WaterBender_Enemy waterEnemy = enemyWaterBender.GetComponent<WaterBender_Enemy>();


        airEnemy.isCombat();
        airPlayer.isCombat();
        airPlayerAssasin.isCombat();
        airEnemyAssasin.isCombat();
        airWarrior.isCombat();
        airWarriorEnemy.isCombat();
        earthPlayerWarrior.isCombat();
        earthPlayerAssasin.isCombat();
        earthPlayer.isCombat();
        earthEnemy.isCombat();
        earthEnemyWarrior.isCombat();
        earthEnemyAssasin.isCombat();
        firePlayer.isCombat();
        firePlayerAssasin.isCombat();
        firePlayerWarrior.isCombat();
        fireEnemy.isCombat();
        fireEnemyAssasin.isCombat();
        fireEnemyWarrior.isCombat();
        waterPlayer.isCombat();
        waterPlayerAssasin.isCombat();
        waterPlayerWarrior.isCombat();
        waterEnemy.isCombat();
        waterEnemyAssasin.isCombat();
        waterEnemyWarrior.isCombat();

    }

    void turnOffCombat()
    {
        print("turning on combat");
        Airbender_Enemy airEnemy = enemyAirBender.GetComponent<Airbender_Enemy>();
        AirBender airPlayer = AirBender.GetComponent<AirBender>();
        Assasin airPlayerAssasin = AirAssasin.GetComponent<Assasin>();
        Assasin_Enemy airEnemyAssasin = enemyAirAssasin.GetComponent<Assasin_Enemy>();
        Warrior airWarrior = AirWarrior.GetComponent<Warrior>();
        Warrior_Enemy airWarriorEnemy = enemyAirWarrior.GetComponent<Warrior_Enemy>();
        Assasin earthPlayerAssasin = EarthAssasin.GetComponent<Assasin>();
        Assasin_Enemy earthEnemyAssasin = enemyEarthAssasin.GetComponent<Assasin_Enemy>();
        Warrior earthPlayerWarrior = EarthWarrior.GetComponent<Warrior>();
        Warrior_Enemy earthEnemyWarrior = enemyEarthWarrior.GetComponent<Warrior_Enemy>();
        EarthBender_Enemy earthEnemy = enemyEarthBender.GetComponent<EarthBender_Enemy>();
        EarthBender earthPlayer = EarthBender.GetComponent<EarthBender>();
        Assasin firePlayerAssasin = FireAssasin.GetComponent<Assasin>();
        Assasin_Enemy fireEnemyAssasin = enemyFireAssasin.GetComponent<Assasin_Enemy>();
        Warrior firePlayerWarrior = FireWarrior.GetComponent<Warrior>();
        Warrior_Enemy fireEnemyWarrior = enemyFireWarrior.GetComponent<Warrior_Enemy>();
        FireBenderEnemy fireEnemy = enemyFireBender.GetComponent<FireBenderEnemy>();
        FireBender firePlayer = FireBender.GetComponent<FireBender>();
        Assasin waterPlayerAssasin = WaterAssasin.GetComponent<Assasin>();
        Assasin_Enemy waterEnemyAssasin = enemyWaterAssasin.GetComponent<Assasin_Enemy>();
        Warrior waterPlayerWarrior = WaterWarrior.GetComponent<Warrior>();
        Warrior_Enemy waterEnemyWarrior = enemyWaterWarrior.GetComponent<Warrior_Enemy>();
        WaterBender waterPlayer = WaterBender.GetComponent<WaterBender>();
        WaterBender_Enemy waterEnemy = enemyWaterBender.GetComponent<WaterBender_Enemy>();


        airEnemy.notCombat();
        airPlayer.notCombat();
        airPlayerAssasin.notCombat();
        airEnemyAssasin.notCombat();
        airWarrior.notCombat();
        airWarriorEnemy.notCombat();
        earthPlayerWarrior.notCombat();
        earthPlayerAssasin.notCombat();
        earthPlayer.notCombat();
        earthEnemy.notCombat();
        earthEnemyWarrior.notCombat();
        earthEnemyAssasin.notCombat();
        firePlayer.notCombat();
        firePlayerAssasin.notCombat();
        firePlayerWarrior.notCombat();
        fireEnemy.notCombat();
        fireEnemyAssasin.notCombat();
        fireEnemyWarrior.notCombat();
        waterPlayer.notCombat();
        waterPlayerAssasin.notCombat();
        waterPlayerWarrior.notCombat();
        waterEnemy.notCombat();
        waterEnemyAssasin.notCombat();
        waterEnemyWarrior.notCombat();
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
