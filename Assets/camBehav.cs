using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camBehav : MonoBehaviour
{
    public Vector3 camPos;
    // Start is called before the first frame update
    void Start()
    {
        camPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        camPos = transform.position;
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            camPos.z = camPos.z - 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            camPos.z = camPos.z + 0.05f;
        }
        camPos.x = camPos.x + 0.1f;
        transform.position = camPos;
    }
}
