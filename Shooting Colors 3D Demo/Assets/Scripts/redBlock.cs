using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBlock : MonoBehaviour
{
    public bool go_left;
    public bool go_right;
    public bool go_forward;
   
    void OnTriggerEnter(Collider other)
    {
          if(other.gameObject.tag == "bullet")
     {
         print("çarpişmaa");

                   if(go_left) 
                   {
                       other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;            //kalan güçler sıfırlandı
                       other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1,0,0) * 250); // yeni pozisyona geçildi -- sola git
                   }
                   if(go_forward)
                   {
                       other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;    
                       other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1) * 250);
                   }
      
     }
        
    }
}
