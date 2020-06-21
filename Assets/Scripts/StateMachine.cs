using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum State
{
    TITLE,
    PLAYERTURN,
    COMBAT,
    WIN,
    LOSE
}

public class StateMachine : MonoBehaviour
{

    //Scenes
    //0- Start Menu
    //1- Controls
    //2- Game
    //3- Win
    //4- Lose

    public int playerNum;
    public int enemyNum;
    public bool isBattle;
    public State state;
    GameObject[] Enemy_pieces;
    GameObject[] Player_pieces;

    //private int prevScene

    void Start()
    {
        isBattle = false;
        state = State.TITLE;
    }

    void PlayGame()
    {
        SceneManager.LoadScene(2);
        state = State.PLAYERTURN;
    }

    void GoToControls()
    {
        SceneManager.LoadScene(1);
    }

    void GoBack()
    {
        //prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }

    void Shopping()
    {

        // if they press next button

        Enemy_pieces = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        Player_pieces = GameObject.FindGameObjectsWithTag("Player_Piece");

        Vector3[] Enemy_Locations = new Vector3[Enemy_pieces.Length];
        Vector3[] Player_Locations = new Vector3[Player_pieces.Length];

        for (int i = 0; i < Enemy_pieces.Length; i++)
        {
            Enemy_Locations[i] = Enemy_pieces[i].transform.position;
        }

        for (int i = 0; i < Player_pieces.Length; i++)
        {
            Player_Locations[i] = Player_pieces[i].transform.position;
        }

    }

    bool isRoundOver()
    {

        Enemy_pieces = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        Player_pieces = GameObject.FindGameObjectsWithTag("Player_Piece");

        playerNum = Player_pieces.Length;
        enemyNum = Enemy_pieces.Length;

        if (playerNum == 0 || enemyNum == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /*
    bool whoWon()
    {

    }
    */

    IEnumerator WinGame()
    {
        SceneManager.LoadScene(3);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
        state = State.WIN;
    }

    IEnumerator LoseGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(4);
        state = State.LOSE;
    }

}