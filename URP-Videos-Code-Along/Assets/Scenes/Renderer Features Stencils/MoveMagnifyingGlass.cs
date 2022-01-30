using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMagnifyingGlass : MonoBehaviour
{
    float prevX;
    bool mouseDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) mouseDown = true;
        if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
            prevX = 0;
        }

        if (mouseDown)
        {
            Vector3 mousePos = Input.mousePosition;

            if (prevX != 0)
            {

                float offset = mousePos.x - prevX;
                Vector3 pos = transform.position;
                pos.x -= offset * 0.01f;
                transform.position = pos;
            }

            prevX = mousePos.x;
        }
    }
}
