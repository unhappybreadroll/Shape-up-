using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{               
    public void loadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //this lets me quit the game  
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

}              // this all lests me go from the first scene and the next  