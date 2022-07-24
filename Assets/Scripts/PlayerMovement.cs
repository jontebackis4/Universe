using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float turnSpeed = 5f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.Space))
            transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(0, -movementSpeed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }
}
