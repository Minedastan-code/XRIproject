using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    MeshRenderer myrenderer;
    Rigidbody myrigidbody;
    [SerializeField] int myTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        myrenderer = GetComponent<MeshRenderer>();
        myrigidbody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > myTime)
        {

            myrenderer.enabled = true;
            myrigidbody.useGravity = true;
        }
    }
}
