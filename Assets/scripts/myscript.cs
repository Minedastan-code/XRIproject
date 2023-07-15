using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class myscript : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions ()
    {
        Debug.Log("Hello, welcome to the game!");
        Debug.Log("Move your players with wasd");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer ()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }


     
}
