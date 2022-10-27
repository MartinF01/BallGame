using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static bool IsPaused { get; private set; } = false;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 3 && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrResumeGame();
        }
    }
    public static void PauseOrResumeGame()
    {
        IsPaused = !IsPaused;
        if (IsPaused)
        {
            Time.timeScale = 0f;
            PauseMenu.ShowMenu();
        }
        else
        {
            Time.timeScale = 1f;
            PauseMenu.HideMenu();
        }
    }

}
