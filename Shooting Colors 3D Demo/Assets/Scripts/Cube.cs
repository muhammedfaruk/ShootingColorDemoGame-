using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Material materialTarget;    //eğer yeni bölüm oluşturursanız buradaki renkleri görev objesindeki renklere göre ayarlayınız.

    Material _material;   

    public bool check;
    SceneController sceneController;
    SoundManager soundManager;



    private void Start() {    
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>(); //acces SceneController.
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
   
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullet"){

            soundManager.PlaySound(1);
            _material = other.gameObject.GetComponent<Renderer>().material;
            GetComponent<Renderer>().material  = _material;

            if( _material.color == materialTarget.color)
            {
                check = true;       // right color
            }
            else 
            {
                check = false;           // false color
            }         
            
        }
        
    }


}
