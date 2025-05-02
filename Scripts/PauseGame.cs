using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public AudioSource pauseJingle;
    public GameObject pauseMenu;
    void Update()
    {
        if(Input.GetButtonDown("Cancel")){
            if(!gamePaused){
                pauseJingle.Play();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else{
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame(){
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }
    public void RestartGame(){
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void ReturnMainMenu(){
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = true;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
