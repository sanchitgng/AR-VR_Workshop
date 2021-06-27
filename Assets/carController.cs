using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    public float speed = 10;
    public float turnValue = 10;

    float horizontalInput;
    float verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // make the car move
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // make the car rotate
        transform.Rotate(Vector3.up * Time.deltaTime * turnValue * horizontalInput * verticalInput);

        if (Input.GetButtonDown("Fire1"))
        {
            Application.Quit(); //does not work in editor
        }

    }
}
