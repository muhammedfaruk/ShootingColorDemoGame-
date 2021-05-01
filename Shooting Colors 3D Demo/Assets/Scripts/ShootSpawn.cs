using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpawn : MonoBehaviour
{
    SoundManager soundManager;
    public GameObject bulletPrefabPurple, bulletPrefabGreen, bulletPrefabOrange;
    ParticleSystem effect;

    private void Start() {
        effect = GetComponentInChildren<ParticleSystem>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    public void ControlandSpawn(string color)
    {
        if(color == "purple")
        {
            GameObject bulletObject = Instantiate (bulletPrefabPurple, transform.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody>().AddForce(transform.forward * 250);
             SoundAndEffects(); 

        }else if(color == "green")
        {
            GameObject bulletObject = Instantiate (bulletPrefabGreen, transform.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody>().AddForce(transform.forward * 250);
             SoundAndEffects(); 

        }else
        {
            GameObject bulletObject = Instantiate (bulletPrefabOrange, transform.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody>().AddForce(transform.forward * 250);
              SoundAndEffects();              
            
        }


    }

    void SoundAndEffects()
    {
        effect.Play();
        soundManager.PlaySound(0);
    }

    
}
