using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headPoints : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "point") { logic.addScore(); }
    }
}
