using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScene : MonoBehaviour
{
  public void RestartGame()
    {
        Debug.Log("dşllfmsd");
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("1");
    }

}
