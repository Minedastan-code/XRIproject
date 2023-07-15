using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody myrigidBody;

    [SerializeField] float mainThrust = 100f;
    [SerializeField] float mainRotate = 100f;

    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
       myrigidBody= GetComponent<Rigidbody>();
       myAudio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
        
        void ProcessThrust()
        {
           if (Input.GetKey(KeyCode.Space))
            {
                if(!myAudio.isPlaying)
                {
                 myAudio.Play();
                }
               
                myrigidBody.AddRelativeForce(Vector3.up*mainThrust*Time.deltaTime);
            }
           else
            {
                myAudio.Stop();
            }

          
        }
         void ProcessRotation ()
        {
            if (Input.GetKey(KeyCode.A))
            {
                ApplyRotation(mainRotate);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                ApplyRotation(-mainRotate);
            }
        }
    }

    public void ApplyRotation(float rotationThisFrame)
    {
        myrigidBody.freezeRotation = true; //freezing rotation so we can manualy rotate
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        myrigidBody.freezeRotation = false; 
    }
}
