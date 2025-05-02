using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9 : MonoBehaviour
{
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redirectToLevel = 13;
        RedirectToLevel.nextLevel = 14;
        StartCoroutine(FadeInOff());
    }
    IEnumerator FadeInOff(){
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
