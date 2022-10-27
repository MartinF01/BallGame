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
        if (SceneManager.GetActiveScene().buildIndex >= 4 && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrResumeGame();
        }
    }
    public static void PauseOrResumeGame()
    {
        IsPaused = !IsPaused;
        if (IsPaused)
        {
            PauseMenu.ShowMenu();
        }
        else
        {
            PauseMenu.HideMenu();
        }
    }

}
