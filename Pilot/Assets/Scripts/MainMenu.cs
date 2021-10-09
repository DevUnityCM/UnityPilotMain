using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This function will load from the menu to the game scene 
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // This function will close the program 

    public void QuitGame()
    {
        Debug.Log("This will exit from the game");
        Application.Quit();
    }
}
