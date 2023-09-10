using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {
            // Release the object from its parent
            transform.parent = null;

            // Set isKinematic to false to allow physics interactions
            rb.isKinematic = false;

            // Apply force to the Rigidbody2D
            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
    }
}
