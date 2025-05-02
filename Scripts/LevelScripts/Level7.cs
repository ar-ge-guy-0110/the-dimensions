using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level7 : MonoBehaviour
{
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redirectToLevel = 11;
        RedirectToLevel.nextLevel = 12;
        StartCoroutine(FadeInOff());
    }
    IEnumerator FadeInOff(){
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
