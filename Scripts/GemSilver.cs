using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other){
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
         if (other.gameObject.tag == "Player") 
         {
             Debug.Log ("Collided");
         }
    }
}
