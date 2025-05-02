using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishArea : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource  levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject fadeOut;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    void OnTriggerEnter(){
        GameObject.Find("Player").GetComponent<ThirdPersonMovement>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        timeCalc = GlobalTimer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Kalan Zaman: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Skor: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Toplam Skor: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }
    IEnumerator CalculateScore(){

        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
