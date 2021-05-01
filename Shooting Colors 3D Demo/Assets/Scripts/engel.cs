using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    ShooterControl shooterControl;
    SceneController sceneController;

    private void Start() {
       
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }
     void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "bullet")
       {
           sceneController.CheckLevelSolution();
           Destroy(other.gameObject);
           sceneController.shootCheck = true;
           
       }
       
   }
}
