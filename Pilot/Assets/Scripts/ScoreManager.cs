using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    
    // Change score based on player activity
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = " Money: " + score.ToString();
       
        // if player achive more than 10 points will be transfered to the second level ...... 
        if(score > 10)
        {
            SceneManager.LoadScene(2);
        }

        // If player hit escape button enter in menu scene 

        
    }
     
    
}
