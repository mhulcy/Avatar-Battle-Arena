using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int playerMoney;
    public Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        playerMoney = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addMoney(int moneyToAdd)
    {
        playerMoney += moneyToAdd;
    }

    public void subtractMoney(int moneyToSubtract)
    {
        if(playerMoney - moneyToSubtract <= 0)
        {
            Debug.Log("We dont have enough money");
        }
        else
        {
            playerMoney -= moneyToSubtract;
        }
    }

    public int getPlayerMoney()
    {
        return playerMoney;
    }
}
