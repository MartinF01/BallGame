using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionLoader : MonoBehaviour
{
    Button optionsButton;
    // Start is called before the first frame update
    void Start()
    {
        optionsButton = GetComponent<Button>();
        optionsButton.onClick.AddListener(ShowOptions);
    }

    void ShowOptions()
    {
        OptionMenu.ShowMenu();
    }
}
