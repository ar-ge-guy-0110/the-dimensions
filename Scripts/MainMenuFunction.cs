using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject bestScoreDisplay;
    public int bestScore;
    void Start(){
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "En İyi: " + bestScore;
    }
    public void PlayGame(){
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void QuitGame(){
        Application.Quit();
    }
    public void Credits(){
        SceneManager.LoadScene(4);
    }
    public void ResetBest(){
        PlayerPrefs.SetInt("LevelScore", 0);
        PlayerPrefs.SetInt("LevelScore2", 0);
        bestScoreDisplay.GetComponent<Text>().text = "En İyi: " + bestScore;
    }
}
