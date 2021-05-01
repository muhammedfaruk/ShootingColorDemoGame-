using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    UImanager uıManager;
    private void Start() {
        uıManager = GameObject.Find("UImanager").GetComponent<UImanager>(); 
    }
    public void LevelControl()
    {
        if(PlayerPrefs.GetInt("Level", 0) == 0)
        {
              //DoNothing
        }        
        
        if(PlayerPrefs.GetInt("Level") == 1) 
        {
           SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
        if(PlayerPrefs.GetInt("Level") == 2)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
        if(PlayerPrefs.GetInt("Level") == 3)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
        if(PlayerPrefs.GetInt("Level") == 4)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
        if(PlayerPrefs.GetInt("Level") == 5)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }

    }
}