using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    bool downArrowPressed = false;
    bool upArrowPressed = false;
    public float speed = 7f;
    float maxY = 4;
    float minY = -4;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downArrowPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            downArrowPressed = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upArrowPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            upArrowPressed = false;
        }

        if (downArrowPressed && transform.position.y > minY)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
        else if (upArrowPressed && transform.position.y < maxY)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
    }


}
