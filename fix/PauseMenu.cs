using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;
 

    public GameObject pauseGameMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void LoadAi()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Ai");
    }

    public void Load1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1v1");
    }

    public void LoadAih()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Ai2");
    }

    public void LoadAiu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Ai3");
    }

}
