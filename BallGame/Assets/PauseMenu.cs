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
        DontDestroyOnLoad(this.gameObject);
        pauseMenu = GetComponent<Canvas>();
        
    }
    public static void ShowMenu()
    {
        pauseMenu.enabled = true;
    }
    public static void HideMenu()
    {
        pauseMenu.enabled = true;
    }

    public void Resume()
    {
        GameManagement.PauseOrResumeGame();
    }
    public void ShowOptions()
    {
        GameManagement.PauseOrResumeGame();
        SceneLoader.LoadScene("Options");
    }
    public void ReturnToMainMenu()
    {
        GameManagement.PauseOrResumeGame();
        SceneManager.LoadScene(1);
    }

}
