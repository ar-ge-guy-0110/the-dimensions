using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(){
        GlobalScore.currentScore += 250;
        collectSound.Play();
        Destroy(gameObject);
    }
}
