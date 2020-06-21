using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int prevScene;
    void Start()
    {
        
    }
    //Scenes
    //0- Start Menu
    //1- Controls
    //2- Game
    public void PlayGame() {
        prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
    }

    public void GoToContols() {
        prevScene = SceneManager.GetActiveScene().buildIndex;
        print(prevScene);
        SceneManager.LoadScene(1);
    }

    public void GoBack() {
        print(prevScene);
        if (prevScene == 0) {
            SceneManager.LoadScene("Board");
        }
        else
            SceneManager.LoadScene("Title");
        
    }
}
