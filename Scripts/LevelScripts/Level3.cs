using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redirectToLevel = 7;
        RedirectToLevel.nextLevel = 8;
        StartCoroutine(FadeInOff());
    }
    IEnumerator FadeInOff(){
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
