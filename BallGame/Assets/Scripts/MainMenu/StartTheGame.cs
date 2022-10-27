using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartTheGame : MonoBehaviour
{
    Button startButton;
    private void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
    }
    void StartGame()
    {
        SceneLoader.LoadScene("LevelMenu");
    }
}
