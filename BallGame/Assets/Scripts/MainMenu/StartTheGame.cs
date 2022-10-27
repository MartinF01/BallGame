using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour
{
    public void LoadSceneColorSelection()
    {
        SceneManager.LoadScene(1);
    }

    public void StartIt()
    {
        SceneManager.LoadScene(2);
    }
}
