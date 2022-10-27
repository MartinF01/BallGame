using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Button[] levelButtons;

    private void Start()
    {
        foreach(var levelButton in levelButtons)
        {
            levelButton.onClick.AddListener(() => LoadLevel(levelButton));
        }
    }

    public void LoadLevel(Button button)
    {
        SceneManager.LoadScene(button.name);
    }
}
