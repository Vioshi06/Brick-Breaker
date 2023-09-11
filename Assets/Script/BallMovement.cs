using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Canvas2;
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    void Start(){
        Canvas2.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {
            transform.parent = null;
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
            Canvas2.SetActive(false);
        }
    }
}
