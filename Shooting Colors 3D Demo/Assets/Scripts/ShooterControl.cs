using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class ShooterControl : MonoBehaviour
{
    Animator animator;
    
    ShootSpawn shootColorSpawn;
    SceneController sceneController;
    
    public bool shootCheck;
    void Start()
    {
        shootCheck = true;
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
        animator = gameObject.GetComponent<Animator>();
        shootColorSpawn = gameObject.GetComponent<ShootSpawn>();
    }

  
    private void OnMouseDown() {

     if(sceneController.shootCheck == true)
         Shoot();               
       
    }

    private void Shoot()
    {
        sceneController.shootCheck = false;
        animator.SetTrigger("shoot"); 
        if( gameObject.tag == "purple")
        {
            shootColorSpawn.ControlandSpawn("purple");                    
        }
        else if( gameObject.tag == "green" )
        {
            shootColorSpawn.ControlandSpawn("green");           
        }
        else if( gameObject.tag == "orange" )
        {
            shootColorSpawn.ControlandSpawn("orange");
        }


    }


    
}
