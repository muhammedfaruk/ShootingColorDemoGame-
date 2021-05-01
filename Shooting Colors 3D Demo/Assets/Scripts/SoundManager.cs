using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource myAudioSource;

    public AudioClip[] sounds;

    private void Start() {
        myAudioSource = GetComponent<AudioSource>();
    }
   
   public void PlaySound(int i)
   {
       if(i == 0)    // element 0 is a shoot sound
       {
           myAudioSource.PlayOneShot(sounds[0]);
       }
       else if (i == 1)   // element 1 is a block collision sound
       {
           myAudioSource.PlayOneShot(sounds[1]);
       }
       else if(i == 2)
       {
           myAudioSource.PlayOneShot(sounds[2]);
       }
   }
}
