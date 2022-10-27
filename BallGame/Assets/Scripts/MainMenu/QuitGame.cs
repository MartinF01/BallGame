using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button quitButton;
    void Start()
    {
        Button button = quitButton.GetComponent<Button>();
        button.onClick.AddListener(ExitGame);
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}
