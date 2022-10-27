using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    public Material ballMaterial;
    public Button nextButton;
    private void Start()
    {
        Button buttonNext = nextButton.GetComponent<Button>();
        buttonNext.onClick.AddListener(ChangeColor);
    }

    private void ChangeColor()
    {
        ballMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
