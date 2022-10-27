using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
    public static Canvas optionMenu;
    public static GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        optionMenu = GetComponent<Canvas>();
        sphere = GameObject.FindWithTag("Demo");
        optionMenu.enabled = false;
        sphere.SetActive(false);
    }
    public static void ShowMenu()
    {
        optionMenu.enabled = true;
        sphere.SetActive(true);
    }
    public static void HideMenu()
    {
        optionMenu.enabled = false;
        sphere?.SetActive(false);

        if(SceneManager.GetActiveScene().buildIndex >= 3)
        {
            GameManagement.PauseOrResumeGame();
        }
    }
}
