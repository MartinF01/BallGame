using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static Canvas pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = GetComponent<Canvas>();
        pauseMenu.enabled = false;
    }
    public static void ShowMenu()
    {
        pauseMenu.enabled = true;
    }
    public static void HideMenu()
    {
        pauseMenu.enabled = false;
    }

    public void Resume()
    {
        GameManagement.PauseOrResumeGame();
    }
    public void ShowOptions()
    {
        HideMenu();
        OptionMenu.ShowMenu();
    }
    public void ReturnToMainMenu()
    {
        GameManagement.PauseOrResumeGame();
        SceneManager.LoadScene(1);
    }

}
