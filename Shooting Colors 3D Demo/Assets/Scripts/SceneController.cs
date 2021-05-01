using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SceneController : MonoBehaviour
{
    GameObject[] cubes;
    public int cubeNumbers;   
    List<Cube> cubesList;
    UImanager uı;

    public bool shootCheck;

    void Awake()
    {
        shootCheck  = true;
        cubeNumbers = GameObject.FindGameObjectsWithTag("cube").Length;
        cubesList = GameObject.FindObjectsOfType<Cube>().ToList();
        uı = GameObject.Find("UImanager").GetComponent<UImanager>();
    }
    public void CheckLevelSolution()
    {
        if(cubesList.FindAll(a => a.check == true).Count == cubeNumbers)  // count right color
        {                   
          
          Debug.Log("Level Completed");
          panelActive();
            
        }
    }

    public void panelActive()
    {
        uı.WonPanel();
    }

    public void ShootCheckFalse()
    {
        shootCheck = false;   
    }
     public void ShootCheckTrue()
    {
        shootCheck = true;       
    }


    
     
}
   