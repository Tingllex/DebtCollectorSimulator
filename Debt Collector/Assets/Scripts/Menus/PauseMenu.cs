using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject popUpMenuUI;


    private void Start()
    {
        TimerCountdown.isGameOver = false;
        TimerCountdown.timeValue = 120;
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (TimerCountdown.isGameOver == false && WinScore.isWinScreen == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused)
                {
                    Resume();
                    Cursor.lockState = CursorLockMode.Locked;
                }
                else
                {
                    Pause();
                    Cursor.lockState = CursorLockMode.Confined;
                }
            }
        }
    }

    public void Resume()
    {
        popUpMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    void Pause()
    {
        popUpMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUITTING GAME...");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        TimerCountdown.isGameOver = false;
        WinScore.isWinScreen = false;
        Resume();
    }
}
