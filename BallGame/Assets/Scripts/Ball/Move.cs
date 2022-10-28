using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    Vector3 pos;
    public float speed = 7f;
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        //If user presses upArrow or W, direction will be 1
        //If user presses downArrow or S, direction will be -1
        //Otherwise 0
        float direction = Input.GetAxis("Vertical");

        pos.y += direction * Time.deltaTime * speed;
        pos.y = Mathf.Clamp(pos.y, -3.75f, 3.75f);  //Ensures that pos.y stays inbetween -3.75 and 3.75
        transform.position = pos;
    }


}
