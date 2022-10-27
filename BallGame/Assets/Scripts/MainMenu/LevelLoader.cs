using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    public void LoadLevel(Button button)
    {
        SceneManager.LoadScene(button.name);
    }
}
