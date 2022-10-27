using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public static void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public static void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
