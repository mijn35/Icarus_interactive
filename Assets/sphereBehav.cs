using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBehav : MonoBehaviour
{
    public Vector3 posBall;
    public Rigidbody myRigidbody;
    float score;

    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        posBall = transform.position;
        score = 0;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * 8;
        }
       

        posBall = transform.position;
        posBall.x = posBall.x + 0.1f;
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            posBall.z = posBall.z - 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            posBall.z = posBall.z + 0.05f;
        }

        transform.position = posBall;
    }

    [System.Obsolete]
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "obstacle") { Application.LoadLevel(0); }
        if (col.tag == "point") { logic.addScore(); }


    }
}
