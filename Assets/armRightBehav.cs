using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armRightBehav : MonoBehaviour
{
    public int rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && rotation==0)
        {
            transform.Rotate(-2, 0, 0);
            rotation = -2;
        }
        if (rotation < 0 && rotation > -70)
        {
            transform.Rotate(-2, 0, 0);
            rotation = rotation - 2;
        }
        if (rotation < -69 && rotation >-140)
        {
            transform.Rotate(2, 0, 0);
            rotation = rotation - 2;
        }
        if (rotation == -140)
        {
            rotation = 0;   
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            transform.Rotate(30, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) == true )
        {
            transform.Rotate(-30, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            transform.Rotate(-30, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) == true )
        {
            transform.Rotate(30, 0, 0);
        }

    }
    public void Fly()
    {
        transform.Rotate(50, 0, 0);
    }
}
